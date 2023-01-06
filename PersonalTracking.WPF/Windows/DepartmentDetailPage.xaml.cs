using PersonalTracking.WPF.DataBase;
using PersonalTracking.WPF.ViewModels;
using System.Windows;

namespace PersonalTracking.WPF
{

    public partial class DepartmentPage : Window
    {
        private readonly DepartmentViewModel _department; 
        public DepartmentPage()
        {
            InitializeComponent();
            _department = new DepartmentViewModel();
            this.DataContext = _department;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
          
        }
    }
}
