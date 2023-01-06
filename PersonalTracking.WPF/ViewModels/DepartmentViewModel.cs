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

        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get { return _saveCommand; }
        }
        public DepartmentViewModel()
        {
            _service = new DepartmentService();
            LoadDepartments();

            Department = new DepartmentDTO(); 
            _saveCommand = new RelayCommand(Save); 

        }

        // Add a New Department to DB //
        public void Save()
        {
            try
            {
                var IsSaved = _service.AddDepartment(Department);
                if (IsSaved)
                {
                    MessageBox.Show("Department Saved");
                    //LoadDepartments(); 
                }
                else
                {
                    MessageBox.Show("Department Not Saved"); 
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message); 
            }
        }

        // Load all Departments From DB //
        private void LoadDepartments()
        {
            Departments = new ObservableCollection<DepartmentDTO>(_service.GetAllDepartments());
        }
    }
}
