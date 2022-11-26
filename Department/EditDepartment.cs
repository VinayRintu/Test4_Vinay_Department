using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    internal class EditDepartment
    {

        string? connection = "Server=VINDUJA\\MSSQLSERVER01;Database=Test;Trusted_Connection = true;TrustServerCertificate=True";
        SqlConnection? con;
        string? query;
        public void UpdateDepartmentData()
        {
            Console.WriteLine("Enter Department ID  where to Update ");
            int deptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Department Name");
            string dName = Console.ReadLine();
            Console.WriteLine("Enter Department Short Name");
            string DShortName=Console.ReadLine();

            con = new SqlConnection(connection);
            con.Open();
            query = "update Department set DeptName='" + dName + "',DeptShortName='"+DShortName+"' where DeptID=" + deptID + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            con.Close();
            if (objDone == 1)
            {
                Console.WriteLine("Updated Record Successfully");
            }
        }
        public void DeleteEmployeeData()
        {
            Console.WriteLine("Enter Department ID  to Delete ");
            int deptId = int.Parse(Console.ReadLine());
            con = new SqlConnection(connection);
            con.Open();
            query = "delete Department where DeptID=" + deptId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Employee Record Deleted Successfully");
            }
        }
    }
}
