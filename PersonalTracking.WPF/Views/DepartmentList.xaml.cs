using PersonalTracking.WPF.DataBase;
using System.Linq;
using System.Windows.Controls;


namespace PersonalTracking.WPF.Views
{
    public partial class DepartmentList : UserControl
    {
        public DepartmentList()
        {
            InitializeComponent();
            using(PersonalTrackingDbContext context= new PersonalTrackingDbContext()) 
            {
                var departments = context.Departments.ToList(); 
                gridDepartment.ItemsSource= departments;
            }
          
        }
    }
}
