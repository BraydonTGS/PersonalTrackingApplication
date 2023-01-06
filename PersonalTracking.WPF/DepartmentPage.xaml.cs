using PersonalTracking.WPF.DataBase;
using System.Windows;

namespace PersonalTracking.WPF
{

    public partial class DepartmentPage : Window
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }

        // Close the Window //
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Please Fill Out Department Name"); 
            }
            else
            {
                using(PersonalTrackingDbContext context = new PersonalTrackingDbContext())
                {
                    Department dpt = new Department()
                    {
                        DepartmentName = txtDepartmentName.Text,
                    };
                    context.Add(dpt); 
                    context.SaveChanges();
                    MessageBox.Show("Department Saved"); 
                }
            }
        }
    }
}
