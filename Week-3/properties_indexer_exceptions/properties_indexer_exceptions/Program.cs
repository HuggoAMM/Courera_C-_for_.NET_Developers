using properties_indexer_exceptions;

//User user = new User
//{
//    Name = "Test Setter",
//    Age = 20,
//    //City = "Hola"
//};
//Console.WriteLine(user.Name);
//Console.WriteLine(user.CompanyName);
//Console.WriteLine(user.Age);


//StringIndexerType indexerType = new StringIndexerType();
//indexerType[0] = "String 0";
//indexerType[1] = "String 1";

//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine(indexerType[i]);
//}

// Tipo Anonimo
//var obj = new
//{
//    firstName = "Hugo",
//    lastName = "Machorro",
//    salary = 1000,
//    address = new { streetName = 33, city = "Neza"},
//    projects = new[]
//    {
//        new { projectName = "Proyecto 1"},
//        new { projectName = "Proyecto 2"}
//    }
//};

//Console.WriteLine(obj.firstName);
//Console.WriteLine(obj.lastName);
//Console.WriteLine(obj.salary);
//Console.WriteLine(obj.address);
//Console.WriteLine(obj.address.streetName);
//Console.WriteLine(obj.address.city);

//foreach(var item in obj.projects)
//{
//    Console.WriteLine(item.projectName);
//}

//Example Delegate
//SingleCast
//CalculateDelegate calculateDelegate_1 = new CalculateDelegate(DelegateExample.addition);
//CalculateDelegate calculateDelegate_2 = new CalculateDelegate(DelegateExample.multiplication);

//calculateDelegate_1(10);
//Console.WriteLine(DelegateExample.getNumber());

//calculateDelegate_2(10);
//Console.WriteLine(DelegateExample.getNumber());

// Multiple Cast
//CalculateDelegate calculateDelegate_1 = new CalculateDelegate(DelegateExample.addition);

//calculateDelegate_1(10);
//Console.WriteLine(DelegateExample.getNumber());
//calculateDelegate_1 += new CalculateDelegate(DelegateExample.multiplication);
//calculateDelegate_1(10);
//Console.WriteLine(DelegateExample.getNumber());


//Suscriber Model Event
//EventExample eventExample = new EventExample();
//eventExample.event_OddNumber += new EventExample.delegate_OddNumber(EventMessage);
//eventExample.Addition();
//Console.ReadLine();

//static void EventMessage()
//{
//    Console.WriteLine("Event Executed: Add Number");
//}

//Annonymous Method
//AnnonymousMethodExample.InvokeMethod();

//Expression Lambda
var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var count = numbers.Count(x => x % 2 == 0);
Console.WriteLine(count);

//Staement Lambda
List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var count2 = numbers.Count(x => { return x == 5; }); 
Console.WriteLine(count2);