using PersonalTracking.WPF.DataBase;
using System.Linq;
using System.Windows.Controls;


namespace PersonalTracking.WPF.Views
{
    public partial class DepartmentList : UserControl
    {
        private readonly PersonalTrackingDbContext _context; 
        public DepartmentList()
        {
            InitializeComponent();
            PersonalTrackingDbContext context = new PersonalTrackingDbContext();
            _context= context;
            gridDepartment.ItemsSource = _context.Departments.ToList(); 
        
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DepartmentPage departmentPage = new DepartmentPage();
            departmentPage.ShowDialog();
            gridDepartment.ItemsSource = _context.Departments.ToList(); 

        }
    }
}
