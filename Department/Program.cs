// See https://aka.ms/new-console-template for more information
using Department;
using Test4_Vinay_Department;

Console.WriteLine("Hello, World!");

//DB_Connection objDbConnection = new DB_Connection();
//objDbConnection.DBconnection();

DepartmentConsoleEntry objConsole = new DepartmentConsoleEntry();
//objConsole.AddDepartment();

EditDepartment objEditDepartments=new EditDepartment();
//objEditDepartments.UpdateDepartmentData();
objEditDepartments.DeleteEmployeeData();