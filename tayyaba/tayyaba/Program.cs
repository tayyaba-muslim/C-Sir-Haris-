// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!")

//using System.Xml.Schema;

//Console.WriteLine("enter the obtained marks");
//double num = double.Parse(Console.ReadLine());

//Console.WriteLine("enter the Total marks");
//double num1 = double.Parse(Console.ReadLine());
//void percentage()
//{
//    if (num <= num1)
//    {
//        double percentage = num * 100 / num1;


//        Console.WriteLine($"Your percentage  is {double.Round(percentage, 2)}");
//    }
//    else
//    {
//        Console.WriteLine("total marks should be less than obtain marks");
//    }
//}

//percentage();


////LIST

//List<string> Mobiles = new List<string>();
//string userinput;

//do
//{
//    Console.WriteLine("Enter your mobile name");

//    userinput = (Console.ReadLine()).ToLower();
//    if (userinput != "no")
//    {
//        Mobiles.Add(userinput);
//    }

//}
//while (userinput != "no");

//foreach (var item in Mobiles)
//{
//    Console.WriteLine(item);
//}

//generic collection (datatypes fixed hungi)
//queue
//lifo (first in first out)
//example

using System.Collections;
//Queue<string> names = new Queue<string>();
//names.Enqueue("sawera");
//names.Enqueue("ahmed");
//names.Enqueue("shibra");
//names.Enqueue("saba");
//names.Enqueue("ruhi");

//names.Dequeue();  //first in first out (remove)
//foreach(var item in names)
//{
//    Console.WriteLine(item);
//}
////stack
////lifo (last in last out)
////example
//Stack<string> namess = new Stack<string>();
//namess.Push("sawera");
//namess.Push("ahmed");
//namess.Push("shibra");
//namess.Push("saba");
//namess.Push("ruhi");

//namess.Pop();  //last in last out (remove)
//foreach (string item in namess)
//{
//    Console.WriteLine(item);
//}

////NON generic (Any type can become an element. As a object)
////ArrayList

//ArrayList address = new ArrayList();
//address.Add("Gulistan e johar");
//address.Add("Block 12");
//address.Add("Block 18");
//address.Add("Block 19");
//address.Add("Block 14");

//ArrayList person = new ArrayList();

//person.Add("Tayyaba");
//person.Add(21);
//person.Add(03172667345);
//person.Add("Web Developer");
////person.Remove(21);
////person.RemoveAt(0);
////person.RemoveRange(2, 2);

//person.AddRange(address);
////person.Clear();
//bool isname = person.Contains("Web Developer");

//Console.WriteLine(isname);

//foreach (var property in person)
//{
//    Console.WriteLine(property);
//}

//Task (Create an arraylist for mobile specification. Take input from the feature in your arraylist.
//as user types ok in input you have to display a thanks specifictaion.)

//ArrayList Mobiles = new ArrayList();
//string userinput;

//do
//{
//    Console.WriteLine("Enter your Specification");

//    userinput = (Console.ReadLine()).ToLower();
//    if (userinput != "ok")
//    {
//        Mobiles.Add(userinput);
//    }

//}
//while (userinput != "ok");

//foreach (var item in Mobiles)
//{
//    Console.WriteLine(item);
//}

//Dictionary Generics Key:Values

//Dictionary<string, string> Accersiors = new Dictionary<string, string>();
//Accersiors.Add("product 1", "Fast charger");
//Accersiors.Add("product 2", "Cable");
//Accersiors.Add("product 3", "USB");
//Accersiors.Add("product 4", "Handfree");
//Accersiors.Add("product 5", "Air pods");
//Accersiors.Add("product 6", "Smart Watch");

//Console.WriteLine(Accersiors["product 4"]);

//Console.WriteLine(Accersiors.ContainsKey("Product 3"));
//Console.WriteLine(Accersiors.ContainsValue("USB"));
////for (int i = 1; i <=6; i++)
////{
////    Console.WriteLine(Accersiors["product" + i]);
////}

//foreach (var item in Accersiors)
//{
//    string[] test = (item.ToString()).Split(","); //returns an array
//    string key = test[0].Trim('['); //product 1
//    string value = test[1].Trim(']');
//    Console.WriteLine("This is key : {0} & This is value : {1}", key, value);


//}

//Hashtable (Non generic)
//Hashtable singer = new Hashtable();
//singer.Add("Top 1", "Shereya");
//singer.Add(2, "Atif Aslam");
//singer.Add(3, "Arijit Singh");
//singer.Add(4.0, "Jubin");
//singer.Add(false, 1234);

//Console.WriteLine(singer [4.0]);
//foreach (DictionaryEntry item in singer)
//{
//    Console.WriteLine(item.Key+":" + item.Value);
//}

//string method
//string test = "we-are-learning-c#";
//Console.WriteLine(test.Replace("learning", "Mastering"));
//Console.WriteLine(test.ToLower());
//Console.WriteLine(test.ToUpper());

//string[] abc = test.Split("-");
//Console.WriteLine(abc);
//Console.WriteLine(test.Trim('-'));


//classes and object


person abc = new person();
Console.WriteLine(abc.FName);

abc.FName = "Sawera";
abc.CellNO = "03128989838293";
abc.Address = "Nazimabad";
abc.age = 20;

Console.WriteLine(abc.FName);
Console.WriteLine(abc.CellNO);
Console.WriteLine(abc.Address);
Console.WriteLine(abc.age);

person saw = new person("saw", "923134567798", "nagan", 70);
class person
{
    public string FName, CellNO, Address;
    public int age;

    public person()
    {
        this.FName = "Anonyums";
        this.CellNO = "Anonyums";
        this.Address = "Unknown";
        this.age = 20;
    }

    public person(string name, string no, string add, int age)
    {
        this.FName = name;
        this.CellNO = no;
        this.Address = add;
        this.age = age;
    }
             

}



