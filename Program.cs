using Exception_Task.Models;
using Exception_Task.Utilites.Exceptions;
#region Metod ile yazilmis task

//Human human = new Human();  
//tryagain:
//try
//{
//Console.WriteLine("Enter Name:");
//string name= Console.ReadLine();
//Console.WriteLine("Enter Surname:");
//string surname = Console.ReadLine();
//Console.WriteLine("Enter Age:");
//int age =int.Parse(Console.ReadLine());
//Human[] humans = new Human[0];
//AddHuman(humans,age,name,surname);

//}
//catch (Exception ex)
//{

//	Console.WriteLine(ex.Message);
//}

//void AddHuman(Human[] humans,int age,string name,string surname)
//{
//	if (age<=0)
//	{
//		throw new MyExcepition("Enter your age correctly!");
//	}
//	human.Age = age;
//	human.Name = name;
//	human.Surname = surname;	
//	Array.Resize(ref humans, humans.Length+1);
//	humans[humans.Length-1] = human;
//	Console.WriteLine("The information saved ");
//}
//	goto tryagain;
#endregion



try
{
Console.WriteLine("Enter Name:");
string name= Console.ReadLine();
Console.WriteLine("Enter Surname:");
string surname = Console.ReadLine();
Console.WriteLine("Enter Age:");
int age =int.Parse(Console.ReadLine());
Human human = new Human(name,surname,age);

}
catch (Exception ex)
{

	Console.WriteLine(ex.Message);
}