using PersonalTracking.WPF.DataBase;
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
        using (PersonalTrackingDbContext dbContext = new PersonalTrackingDbContext())
        {

        }
      
    }
}
