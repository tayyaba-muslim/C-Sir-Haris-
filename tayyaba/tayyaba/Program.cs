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


//person abc = new person();
//Console.WriteLine(abc.FName);

//abc.FName = "Sawera";
//abc.CellNO = "03128989838293";
//abc.Address = "Nazimabad";
//abc.age = 20;

//Console.WriteLine(abc.FName);
//Console.WriteLine(abc.CellNO);
//Console.WriteLine(abc.Address);
//Console.WriteLine(abc.age);

//person saw = new person("saw", "923134567798", "nagan", 70);
//class person
//{
//    public string FName, CellNO, Address;
//    public int age;

//    public person()
//    {
//        this.FName = "Anonyums";
//        this.CellNO = "Anonyums";
//        this.Address = "Unknown";
//        this.age = 20;
//    }

//    public person(string name, string no, string add, int age)
//    {
//        this.FName = name;
//        this.CellNO = no;
//        this.Address = add;
//        this.age = age;
//    }


//}

//OOP (object oriented programming)
//Inheritance


//Vehicle accord = new Vehicle();
//accord.run();

//Car camry = new Car("Toyoto Camry", "2024", "v8", "320 kph");
//camry.run();
//camry.stop();

////Parent Class (Base Class)(Super Class)
//public class Vehicle
//{
//    public string speed;

//   public void run()
//    {
//        Console.WriteLine("Vehicle starting running");
//    }
//    public void stop()
//    {
//        Console.WriteLine("Vehicle is stopped");
//    }
//}

////Child Class (Sub Class)(Derived Class)
////Class car extends class

//class Car : Vehicle
//{

//    public string name;
//    public string model;
//    public string power;

//    public Car(string name, string model, string power, string speed)
//    {
//        this.name = name;
//        this.model = model;
//        this.power = power;
//        this.speed = speed;
//    }

//    //over riding run & stop
//    public void run()
//    {
//        Console.WriteLine($" {this.name} is running at {this.speed}");
//    }

//    public void stop()
//    {
//        Console.WriteLine($" {this.name} is stopped with drift");
//    }
//}

//task !!!
//Vehicle accord = new Vehicle();
//accord.run();

//ECar tesla = new ECar("Tesla","high", "Onechargemileage");
//tesla.run();
//tesla.stop();

////grand parent
//public class Vehicle
//{
//    public string speed;

//    public void run()
//    {
//        Console.WriteLine("starting running");
//    }
//    public void stop()
//    {
//        Console.WriteLine("is stopped");
//    }
//}

////parent
//class Car : Vehicle
//{

//    public string name;

//}
////child
//class ECar : Car
//{

//    public string battery;


//    public ECar(string name, string battery, string speed)
//    {
//        this.name = name;
//        this.battery = battery;
//        this.speed = speed;
//    }

//    public void run()
//    {
//        Console.WriteLine($" {this.name} is running at {this.speed} & its battery {this.battery}");
//    }

//    public void stop()
//    {
//        Console.WriteLine($" {this.name} is stopped low speed");
//    }
//}


//frontendDeveloper sawera = new frontendDeveloper();
//sawera.basicDesign();
//sawera.complexDesign();


//backendDeveloper sawera = new backendDeveloper();
//sawera.basicCrud();
//sawera.complexAPIs("sawera");

//FullStack full = new FullStack();
//full.LearningSession();
//full.basicDesign();
//full.complexDesign();
//full.basicCrud();
//full.complexAPIs("sawera");

//manager Depart = new manager();
//manager.welcome();
//Depart.ProjectManager();
//Depart.Marketing();
//Depart.HR();
//Depart.Hr();
//Depart.IT();
//Depart.Teamleader();

//interface ()
//interface FrontEndDevelopment
//{
//    void basicDesign();
//    void complexDesign();
//}
//interface backendDevelopment
//{
//    void basicCrud();
//    void complexAPIs(string devName);
//}
//public class frontendDeveloper : FrontEndDevelopment
//{
//    public void basicDesign()
//    {
//        Console.WriteLine("We Will provide you a basic design using Html Css Javascript");
//    }
//    public void complexDesign()
//    {
//        Console.WriteLine("We Will provide you completeDesign using ReactJs and Vue or Nextjs");
//    } 
//}
//public class backendDeveloper : backendDevelopment
//{
//    public void basicCrud()
//    {
//        Console.WriteLine("We Will provide you a basic Crud using Nodejs PHP Pyton");
//    }
//    public void complexAPIs(string devName)
//    {
//        Console.WriteLine($"{devName} Will provide you ComplexAPIs using Nodejs and Pyton");
//    }
//}

//public class FullStack : FrontEndDevelopment  , backendDevelopment
//{
//    public void basicDesign()
//    {
//        Console.WriteLine("We Will provide you a basic design using Html Css Javascript");
//    }
//    public void complexDesign()
//    {
//        Console.WriteLine("We Will provide you completeDesign using ReactJs and Vue or Nextjs");
//    }
//    public void basicCrud()
//    {
//        Console.WriteLine("We Will provide you a basic Crud using Nodejs PHP Pyton");
//    }
//    public void complexAPIs(string devName)
//    {
//        Console.WriteLine($"{devName} Will provide you ComplexAPIs using Nodejs and Pyton");
//    }
//    public void LearningSession()
//    {
//        Console.WriteLine("Sab Parh Liya Humne ");
//    }
//}

//interface Admin
//{
//    void IT();
//    void HR();
//}
//interface IT
//{
//    void Hr();
//    void Marketing();
//}
//interface HR
//{
//    void ProjectManager();
//    void Teamleader();
//}

//abstract public class Office : Admin, IT, HR
//{
//    public void IT()
//    {
//        Console.WriteLine("I'm From IT Department");
//    }
//    public void HR()
//    {
//        Console.WriteLine("I'm From HR Department");
//    }
//    public void Hr()
//    {
//        Console.WriteLine("I'm From Hr Department");
//    }
//    public void Marketing()
//    {
//        Console.WriteLine("I'm From Marketing Department");
//    }
//    public void ProjectManager()
//    {
//        Console.WriteLine("I'm Project Manager");
//    }
//    public void Teamleader()
//    {
//        Console.WriteLine("I'm Teamleader");
//    }
//}

//public class manager : Office
//{
//    static public void welcome()
//    {
//        Console.WriteLine("Enter your name");
//      var name =  Console.ReadLine();
//        Console.WriteLine($"Welcome : {name}");
//    }
//}

//Access Modifier
//Watch citizen = new Watch("CZ123",5000,"Titaniunm Black");
//Console.WriteLine(citizen.model);
//citizen.ShowPrice();
//citizen.ShowColor();c  

//SmartWatch appleWatch = new SmartWatch("Series 9", 4500, "silver",true);
//appleWatch.ShowPrice();
//public class Watch
//{
//    public string ? model;
//    private int price;
//    protected string ? color;

//    public Watch(string model, int price, string color)
//    {
//        this.model = model;
//        this.price = price;
//        this.color = color;
//    }
//    public void ShowPrice()
//    {

//        Console.WriteLine (this.price);

//    }
//    public void ShowColor()
//    {

//        Console.WriteLine(this.color);

//    }
//}

//public class SmartWatch : Watch
//{
//    public bool canCall;
//    public SmartWatch(string model, int price, string color, bool canCall) : base(model, price, color)

//    {  
//        this.canCall = canCall; 
//    }
//    public void ShowWatch()
//    {
//        Console.WriteLine(this.model);
//        this.ShowPrice();
//        Console.WriteLine(this.color);
//        Console.WriteLine(this.canCall);
//    }
//}

//Task-!!!!!!!
//Bike honda = new Bike("Honda", 50000, "Black");
//Console.WriteLine(honda.model);
//honda.ShowPrice();
//honda.ShowColor();
//NewBike yamaha = new NewBike("yamaha", 45000, "blue", true);
//yamaha.ShowBike();
//public class Bike
//{
//    public string? model;
//    private int price;
//    protected string? color;

//    public Bike(string model, int price, string color)
//    {
//        this.model = model;
//        this.price = price;
//        this.color = color;
//    }
//    public void ShowPrice()
//    {

//        Console.WriteLine(this.price);

//    }
//    public void ShowColor()
//    {

//        Console.WriteLine(this.color);

//    }
//}

//public class NewBike : Bike
//{
//    public bool canCall;
//    public NewBike(string model, int price, string color, bool canCall) : base(model, price, color)

//    {
//        this.canCall = canCall;
//    }
//    public void ShowBike()
//    {
//        Console.WriteLine(this.model);
//        this.ShowPrice();
//        Console.WriteLine(this.color);
//        Console.WriteLine(this.canCall);
//    }
//}


//delegate

//maths.Calculate cal;

//cal = maths.add;
//cal(50, 50);

//cal = maths.sub;
//cal(50, 60);

//cal = maths.multiply;
//cal(50, 50);

//cal = maths.divided;
//cal(50, 50);

//public class maths
//{
//    public delegate void Calculate(double num1, double num2);

//        public static void add(double num1, double num2)
//    {
//        Console.WriteLine(num1 + num2);
//    }
//    public static void sub(double num1, double num2)
//    {
//        Console.WriteLine(num1 - num2);
//    }
//    public static void multiply(double num1, double num2)
//    {
//        Console.WriteLine(num1 * num2);
//    }
//    public static void divided(double num1, double num2)
//    {
//        if(num1 != 0) 
//        {  
//            Console.WriteLine(num1 / num2);
//        }
//        else
//        {
//            Console.WriteLine("Method wrong");
//        }
//    }
//}


//Getter and setter (encapsulation)

//burger majestic = new burger("Zinger", 300);
//Console.WriteLine(majestic.name);
//Console.WriteLine(majestic.Price);

//public class burger
//{
//    public string name;
//    private int price;
//    //public int Price { get; set; } //AutoComplete property

//    public int Price
//    {
//        get
//        {
//            return price;
//        }
//        set
//        {
//            if (value <= 2000) 
//            {            
//                price = value;
//            }
//            else
//            {
//                price = 2000;
//            }
//        }

//    }

//    public burger(string name, int price) 
//    {
//        this.name = name;
//        this.price = price;
//    }
//}

//enums (collection of constant integars);

//Console.WriteLine(players.sarfraz + " has " + (int)players.sarfraz + " jersey Number ");
//enum players
//{
//    saim = 55,
//    baber = 60,
//    rizwan = 90,
//    sarfraz = 100,
//    umar = 59,
//    shoaib = 99
//}

//LINQ (Language Integrated Query)
//Ienumerable wo collection jis m hum itration kr skty hen ek ek element m jak get b kr skty hen or set b loops lga skty hen(foreach).
//Iqueryable wo collection jis m hum queries likh skty hen data base sy (DATABASE LIKE QUERIES CAN BE IMPLEMENTED).

//Lambda Expression (Arrow Function) e => e.id

//Employee emp1 = new Employee(1, "Murtaza", "Web Developer", 50000, 33, "Web");
//Employee emp2 = new Employee(2, "Arham", "Web Designer", 45000, 43, "Web");
//Employee emp3 = new Employee(3, "Noman", "Content Creator", 47000, 45, "Media");
//Employee emp4 = new Employee(4, "Furqan", "Team Lead", 70000, 53, "Web");
//Employee emp5 = new Employee(5, "Adeel", "Sales Executive", 60000, 42, "Sales");

//Employee emp6 = new Employee(6, "Muzammil", "Seo & Marketing officer", 57000, 46, "Marketing");

//List<Employee> employees = new List<Employee>();
//employees.Add(emp1);
//employees.Add(emp2);
//employees.Add(emp3);
//employees.Add(emp4);
//employees.Add(emp5);
//employees.Add(emp6);

////Task
////orderby

//employees = employees.OrderBy(emp => emp.name).ThenByDescending(emp => emp.id).ToList();

////where
//employees = employees.Where(emp => emp.age < 33 && emp.salary >= 60000).ToList();

////skip 
//employees = employees.Skip(2).ToList();


////Aggregate function maximum salary
//Console.WriteLine(employees.Max(emp =>emp.salary));
//Employee maxSalPerson = employees.MaxBy(emp => emp.salary);
//Console.WriteLine(maxSalPerson.name + "gets" + maxSalPerson.salary);



////last
////Employee last = employees.Last(t => t.salary < 50000);
////Console.WriteLine(last.salary);

////1 ForEach
//employees.ForEach(emp => Console.WriteLine("id : {0}, name : {1}, designation : {2}, salary : {3}, age : {4}, department :{5},", emp.id, emp.name, emp.designation, emp.salary, emp.age, emp.depart));
//public class Employee
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public int salary { get; set; }
//    public string designation { get; set; }
//    public string depart { get; set; }
//    public int age { get; set; }

//    public Employee(int id, string name, string designation, int salary, int age, string depart)
//    {


//        this.id = id;
//        this.name = name;
//        this.designation = designation;
//        this.salary = salary;
//        this.age = age;
//        this.depart = depart;
//    }


//}
//record ,indexers , namespace

//record

//person a = new person();
//a.Name = "Tayyaba";
//a.age = 21;

//Console.WriteLine(a.age);

//person aa = new person();
//aa.Name = "Tayyaba";
//aa.age = 21;

//Console.WriteLine(a == aa);

//createing object of record class
//person2 b = new person2();
//b.Name = "Tayyaba";
//b.age = 21;

//Console.WriteLine(b);

//person2 bb = new person2();
//bb.Name = "Tayyaba";
//bb.age = 21;

//Console.WriteLine(b == bb);


//public class person
//{
//    public string? Name { get; set; }
//    public int? age { get; set; }
//}

//public record person2
//{
//    public string? Name { get; set; }
//    public int? age { get; set; }
//}

//indexer

//superheros fav3 = new superheros();
//fav3[0] = "IronMan";
//fav3[1] = "SuperMan";
//fav3[2] = "BedMan";

//Console.WriteLine(fav3[2]);

//public class superheros
//{
//    public string[] superNames = new string[3];

//    public string this[int i]
//    {
//        get
//        {
//            return superNames[i];
//        }
//        set
//        {
//            superNames[i] = value;
//        }
//    }
//}

//namespace (Collection of related classess)

using System;
using System.Collections;
using System.Reflection.Metadata;

using tayyaba;

////tooltax
//Vehicle toyota = new Vehicle()
//{
//    name = "Toyota Corolla",
//    regno = 2024
//};

//tooltax a = new tooltax()
//{
//    amount = 5,
//    isPaid = false
//};

//Console.WriteLine(a.isPaid);
//Console.WriteLine(toyota.regno);

//recording rec = new recording();
//rec.Name = "Tayyaba";
//rec.age = 21;
//Console.WriteLine(rec.Name); 
//Console.WriteLine(rec.age);

//Events

//Mycar civic = new Mycar();
//civic.speedUp += new Mycar.speedCar(Mycar.carMoved);
//civic.drive();


//public class Mycar
//{
//    public delegate void speedCar();
//    public event speedCar speedUp;

//    public int speed = 0;

//    public void drive()
//    {
//        for (int i = 0; i < 20; i++)
//        {
//            if(i >= 10)
//                speedUp();
//                Console.WriteLine("Car is moving at " + i + " mph");
//            System.Threading.Thread.Sleep(500);
//        }
//    }
//    public static void carMoved()
//    {
//        Console.WriteLine("the car speed limit is exceeded");
//    }
//}

//Event Task

//Game g1 = new Game();
//g1.boost += new Game.GameMethod(Game.levelup);
//g1.play();

//public class Game
//{
//    public delegate void GameMethod();
//    public event GameMethod boost;

//    public int speed = 0;

//    public void play()
//    {
//        Console.WriteLine("Please Enter The Name");
//        var name = "";
//        do
//        {
//            name = Console.ReadLine();
//            if (name.ToLower() == "tayyaba")
//            {
//                boost();
//                Console.WriteLine(name + " Play The Game");
//                System.Threading.Thread.Sleep(500);
//                break;
//            }
//        }
//        while (name != "exit");
//    }
//    public static void levelup()
//    {
//        Console.WriteLine("Your Level is Up");
//    }
//}

