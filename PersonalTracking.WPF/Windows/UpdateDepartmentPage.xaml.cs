using PersonalTracking.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;

namespace PersonalTracking.WPF.Windows
{    public partial class UpdateDepartmentPage : Window
    {
        private readonly DepartmentViewModel _department;
        public UpdateDepartmentPage(DepartmentViewModel department)
        {
            InitializeComponent();
            _department = department;
            DataContext= _department;
 
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    
    }
}
