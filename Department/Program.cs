// See https://aka.ms/new-console-template for more information
using Department;
using Test4_Vinay_Department;

DepartmentConsoleEntry objConsole = new DepartmentConsoleEntry();
EditDepartment objEditDepartments=new EditDepartment();

Console.WriteLine("Select One Option"+ Environment.NewLine +"1.Add Department Record By List "  + Environment.NewLine+ "2.Add Department By Console" + Environment.NewLine+"3.Update Departmenmt"+Environment.NewLine+"4.Delete Department");
int option=int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        DB_Connection objDbConnection = new DB_Connection();
        objDbConnection.DBconnection();
        break;
    case 2:        
        objConsole.AddDepartment();
        break;
    case 3:
        objEditDepartments.UpdateDepartmentData();
        break;
    case 4:
        objEditDepartments.DeleteEmployeeData();
        break;
}