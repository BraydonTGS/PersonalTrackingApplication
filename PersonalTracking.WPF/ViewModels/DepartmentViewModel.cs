using PersonalTracking.WPF.Models;
using PersonalTracking.WPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTracking.WPF.ViewModels
{
    public class DepartmentViewModel : ViewModelBase
    {
        private DepartmentService _service;

        private ObservableCollection<DepartmentDTO> _departments;
        public ObservableCollection<DepartmentDTO> Departments
        {
            get { return _departments; }
            set { _departments = value; OnPropertyChanged(nameof(Departments));}
        }

        public DepartmentViewModel()
        {
            _service = new DepartmentService();
            LoadDepartments();

        }
        private void LoadDepartments()
        {
            Departments = new ObservableCollection<DepartmentDTO>(_service.GetAllDepartments());
        }
    }
}
