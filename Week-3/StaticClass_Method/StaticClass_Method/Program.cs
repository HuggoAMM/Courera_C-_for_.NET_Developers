using StaticClass_Method;


Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());

Console.WriteLine(Calculate.decrement());

//Extenciones de metodos
int number = 1000;
bool result = number.IsGreaterThan(100);
Console.WriteLine(result);

//Partial Class
var employee = new Employee();
Console.WriteLine("Employee Id: " + employee.EmployeeId);
Console.WriteLine("Employee Name: " + employee.EmployeeName);
employee.DisplayDetails();