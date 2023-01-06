using PersonalTracking.WPF.DataBase;
using PersonalTracking.WPF.ViewModels;
using System.Windows;

namespace PersonalTracking.WPF; 

public partial class MainWindow : Window
{
    public MainWindow()
    { 
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      
    }

    private void btnDepartment_Click(object sender, RoutedEventArgs e)
    {
        lblWindowName.Content = "Department List";
        DataContext = new DepartmentViewModel(); 
    }
}
