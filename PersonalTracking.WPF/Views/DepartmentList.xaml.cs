using PersonalTracking.WPF.DataBase;
using PersonalTracking.WPF.ViewModels;
using System.Linq;
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
            DepartmentPage departmentPage = new DepartmentPage();
            departmentPage.ShowDialog();
            _department = new DepartmentViewModel();
            this.DataContext = _department;
        }
    }
}
