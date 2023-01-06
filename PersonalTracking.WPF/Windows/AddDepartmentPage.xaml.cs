using PersonalTracking.WPF.ViewModels;
using System.Windows;

namespace PersonalTracking.WPF
{

    public partial class AddDepartmentPage : Window
    {
        private readonly DepartmentViewModel _department; 
        public AddDepartmentPage()
        {
            InitializeComponent();
            _department = new DepartmentViewModel();
            DataContext = _department;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
    }
}
