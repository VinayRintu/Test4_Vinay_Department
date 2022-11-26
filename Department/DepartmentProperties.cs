using System.ComponentModel.DataAnnotations;

namespace Test4_Vinay_Department
{
    internal class DepartmentProperties
    {
        [Key]
        public int DeptID { get; set; }
        public string? DeptName { get; set; }
        public string? DeptShortName { get; set; }
    }
}
