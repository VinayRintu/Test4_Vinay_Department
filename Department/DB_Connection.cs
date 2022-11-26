using Microsoft.Data.SqlClient;

namespace Test4_Vinay_Department
{
    internal class DB_Connection : DepartmentList
    {
        string? connection;
        SqlConnection? con;
        string? query;
        public void DBconnection()
        {
            var deptList = DepartmentListMethod();
            connection = "Server=VINDUJA\\MSSQLSERVER01;Database=Test;Trusted_Connection = true;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            query = "insert into Department(DeptName,DeptShortName)" + "values (@deptName,@deptShortName)";

            int isdone = 0;
            foreach (var dept in deptList)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@deptName", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptName;
                cmd.Parameters.Add("@deptShortName", System.Data.SqlDbType.NVarChar, 50).Value = dept.DeptShortName;
                isdone = cmd.ExecuteNonQuery();
                con.Close();
            }
            if (isdone == 1)
            {
                Console.WriteLine("Values  Inserted");
            }
        }
    }
}
