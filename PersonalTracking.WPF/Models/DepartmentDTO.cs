
namespace PersonalTracking.WPF.Models
{
    public class DepartmentDTO : ModelBase
    {
        private int _departmentId;

        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value;  OnPropertyChanged(nameof(DepartmentId)); }
        }

        private string _departmentName;
        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; OnPropertyChanged(nameof(DepartmentName)); }
        }

        public DepartmentDTO()
        {

        }
    }
}
