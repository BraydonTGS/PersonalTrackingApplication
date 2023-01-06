using PersonalTracking.WPF.Models;
using PersonalTracking.WPF.ViewModels;
using PersonalTracking.WPF.Windows;
using System.Windows.Controls;


namespace PersonalTracking.WPF.Views
{
    public partial class DepartmentList : UserControl
    {
        private DepartmentViewModel _department; 
        public DepartmentList()
        {
            InitializeComponent();
            _department= new DepartmentViewModel();
            this.DataContext = _department;
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddDepartmentPage departmentPage = new AddDepartmentPage();
            departmentPage.ShowDialog();
            _department = new DepartmentViewModel();
            this.DataContext = _department;
        }

        private void btnUpdate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _department = new DepartmentViewModel();
            _department.Department = (DepartmentDTO)gridDepartment.SelectedItem;
            UpdateDepartmentPage updateDepartment = new UpdateDepartmentPage(_department);
            updateDepartment.ShowDialog();
            _department = new DepartmentViewModel();
            this.DataContext = _department;
            
        }
    }
}