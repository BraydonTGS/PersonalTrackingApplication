using Microsoft.EntityFrameworkCore.Update.Internal;
using PersonalTracking.WPF.Commands;
using PersonalTracking.WPF.Models;
using PersonalTracking.WPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalTracking.WPF.ViewModels
{
    public class DepartmentViewModel : ViewModelBase
    {
        private DepartmentService _service;

        // Collection of Departments //
        private ObservableCollection<DepartmentDTO> _departments;
        public ObservableCollection<DepartmentDTO> Departments
        {
            get { return _departments; }
            set { _departments = value; OnPropertyChanged(nameof(Departments));}
        }

        // Current Department //
        private DepartmentDTO _department;
        public DepartmentDTO Department
        {
            get { return _department; }
            set { _department = value; OnPropertyChanged(nameof(Department)); }
        }

        // Save Command //
        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get { return _saveCommand; }
        }

        // Update Command //
        private RelayCommand _updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return _updateCommand; }
        }


        // CTOR //
        public DepartmentViewModel()
        {
            _service = new DepartmentService();
            LoadDepartments();
            Department = new DepartmentDTO(); 
            _saveCommand = new RelayCommand(SaveDepartment);
            _updateCommand= new RelayCommand(UpdateDepartment);
        }

        // Load all Departments From DB //
        private async void LoadDepartments()
        {
            try
            {
                var departments = await _service.GetAllDepartments();
                if (departments != null)
                {
                    Departments = new ObservableCollection<DepartmentDTO>(departments);
                }
                else
                {
                    Departments = new ObservableCollection<DepartmentDTO>();
                }
            }
          catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); 
            }
        
        }


        // Add a New Department to DB //
        public void SaveDepartment()
        {
            try
            {
                var IsSaved = _service.AddDepartment(Department);
                if (IsSaved)
                {
                    MessageBox.Show("Department Successfully Saved", "Save Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Unable to Save Department, try again.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Update Department //
        public async void UpdateDepartment()
        {
            try
            {
                var updatedDepartment = await _service.UpdateDepartment(Department); 
                if (updatedDepartment != null)
                {
                    MessageBox.Show("Department Successfully Updated", "Update Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Unable to Update Department, try again.", "Update error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
