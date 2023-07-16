//ShowDatas();

//static void ShowDatas()
//{
//    string fullName = "Kubra Memmedova";
//    string email = "kubra@code.edu.az";

//    string fullData = $"{fullName} - {email}";

//    ShowAge();

//    Console.WriteLine(fullData);
//        ;
//}

//   static void ShowAge()
//{
//    Welcome();
//    int age = 25;

//    Console.WriteLine(age);

//} 

//      static void Welcome()
//{
//    Console.WriteLine("Welcome Kubra");
//}


//static void SumItemOfArray()
//{
//    int[] arr = { 1, 2, 3, 4, 5 };
//    int sum = 0;
//    foreach (var item in arr)
//    {
//        sum += item;
//    }
//    Console.WriteLine(sum);
//}
//SumItemOfArray();




//static void SearchByName()
//{
//    string[] people = { "Sheref", "Pervin", "Cahangir", "Huseyn" };
//    string searchText = "Pervin";

//     foreach (var person in people)
//    {
//         if(person == searchText)
//        {
//            Console.WriteLine(person);
//            break;
//        }
//    }

//    Console.WriteLine("Our Search method is working");
//}
//SearchByName();



//static void SearchByName()
//{
//    string[] people = { "Sheref", "Pervin", "Cahangir", "Huseyn" };
//    string searchText = "Pervin";

//    foreach (var person in people)
//    {
//        if (person == searchText)
//        {
//            Console.WriteLine(person);
//            return;
//        }
//        if (person == "Cahangir")
//        {
//            Console.WriteLine(person);
//            return;
//        }
//    }

//    Console.WriteLine("Our Search method is working");
//}
//SearchByName();

//static void Sum(int number1, int number2)
//{
//      int sum = number1 + number2;
//    Console.WriteLine(sum);
//}
//Sum(5, 9);




//bool isMarried = false;

//static void ShowText(string text, int num)

//{

//    Console.WriteLine(text + "-" +num);
//}
//if (isMarried)
//{
//    Console.WriteLine("Evlidir");
//}
//string str = "Hello P139";
//int number = 55;
//ShowText(str, number);




//static void Login(string username, string pasword)
//{
//    if (username == "samir555" && pasword == "Samir123_")
//    {
//        Console.WriteLine("Login successed");
//    }
//    else
//    {
//        Console.WriteLine("Usernamee or password is wrong");
//    }
//}

//Console.WriteLine("Add your username");
//string username = Console.ReadLine();

//Console.WriteLine("Add your password");
//string password = Console.ReadLine();

//Login(username, password);



Console.WriteLine("Add first number:");
int number1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Add second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("---------------------");

SumNumbers(number1, number2);
static void SumNumbers(int a, int b)
{
    int sum = a + b;
    Console.WriteLine(sum);
}