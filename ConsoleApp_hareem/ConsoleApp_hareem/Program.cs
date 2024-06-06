//using System.Globalization;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp_hareem
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//Console.WriteLine("Hello, World!");
//Console.WriteLine("What is Your Name?");

//string name = Console.ReadLine();
//Console.WriteLine("Welcome " + name + ", to our Console");


//if else
//Console.WriteLine("Enter Your Age");
//int age = Convert.ToInt32(Console.ReadLine());
//if(age>18 && age <= 90)
//{
//    Console.WriteLine("You can vote.");

//}
//else if(age == 18)
//{
//    Console.WriteLine("do you have your cnic?");
//    string ans = Console.ReadLine();
//    ans = ans.ToLower();
//    if(ans == "yes")
//    {
//        Console.WriteLine("You can vote.");
//    }
//    else if(ans == "no")
//    {
//        Console.WriteLine("You can't vote. Get cnic first");
//    }
//    else
//    {
//        Console.WriteLine("Invalid Age.");
//    }
//Console.WriteLine("You can vote if you have your cnic.");
//}
//else if(age <= 0){
//    Console.WriteLine("Invalid Age.");
//}
//else
//{
//    Console.WriteLine("You can't vote.");
//}

//Switch Case

//char choice;
//double num1, num2, result;

//do
//{
//    Console.WriteLine("Choose operation:");
//    Console.WriteLine("1. Addition");
//    Console.WriteLine("2. Subtraction");
//    Console.WriteLine("3. Multiplication");
//    Console.WriteLine("4. Division");
//    Console.WriteLine("5. Exponentiation");
//    Console.WriteLine("6. Square Root");
//    Console.WriteLine("7. Logarithm");
//    Console.WriteLine("8. Sine");
//    Console.WriteLine("9. Exit");

//    Console.Write("Enter your choice: ");
//    choice = Console.ReadKey().KeyChar;
//    Console.WriteLine();

//    switch (choice)
//    {
//        case '1':
//            Console.Write("Enter two numbers: ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            num2 = Convert.ToInt32(Console.ReadLine());
//            result = num1 + num2;
//            Console.WriteLine("Result: " + result);
//            break;
//        case '2':
//            Console.Write("Enter two numbers: ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            num2 = Convert.ToInt32(Console.ReadLine());
//            result = num1 - num2;
//            Console.WriteLine("Result: " + result);
//            break;
//        case '3':
//            Console.Write("Enter two numbers: ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            num2 = Convert.ToInt32(Console.ReadLine());
//            result = num1 * num2;
//            Console.WriteLine("Result: " + result);
//            break;
//        case '4':
//            Console.Write("Enter two numbers: ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            num2 = Convert.ToInt32(Console.ReadLine());
//            if (num2 != 0)
//            {
//                result = num1 / num2;
//                Console.WriteLine("Result: " + result);
//            }
//            else
//            {
//                Console.WriteLine("Error! Division by zero.");
//            }
//            break;
//        case '5':
//            Console.Write("Enter base and exponent: ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            num2 = Convert.ToInt32(Console.ReadLine());
//            result = Math.Pow(num1, num2);
//            Console.WriteLine("Result: " + result);
//            break;
//        case '6':
//            Console.Write("Enter number: ");
//            num1 = Convert.ToDouble(Console.ReadLine());
//            result = Math.Sqrt(num1);
//            Console.WriteLine("Result: " + result);
//            break;
//        case '7':
//            Console.Write("Enter number: ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            result = Math.Log(num1);
//            Console.WriteLine("Result: " + result);
//            break;
//        case '8':
//            Console.Write("Enter angle in degrees: ");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            result = Math.Sin(num1 * Math.PI / 180); // Convert degrees to radians
//            Console.WriteLine("Result: " + result);
//            break;
//        case '9':
//            Console.WriteLine("Exiting calculator. Goodbye!");
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
//            break;
//    }
//} while (choice != '9');


//int[] numbers = new int[5];
//numbers[0] = 2;
//numbers[4] = 25;
//Console.WriteLine(numbers[4]);
//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}
//               for (int i= 0; i < numbers.Length; i++)
//               {
//                   string numbers= Console.ReadLine());
//               numbers[i] = number;
//               }


//Task
//int[] num = new int[10];



//for(var i= 0; i < num.Length; i++)
//{
//    Console.WriteLine("Enter value");
//    var value = Console.ReadLine();
//    num[i] = Convert.ToInt32(value);

//}
//Console.WriteLine("Print all numbers");
//foreach (var number in num)
//{
//    Console.WriteLine(number);
//}

//Jgged array
//            string[][] skillSet =
//            {
//                new string[4]{"php","laravel","html","c#"},
//                 new string[3]{"css","java","json"},
//                  new string[2]{"MySql","Sql"},
//                   new string[1]{"abc"},

//            };

//  void GetSkills(string name){ 

//                Console.WriteLine($"printing {name} skills");

//foreach(var skills in skillSet)
//                {
//                    foreach (var skill in skills)
//                    {
//                        Console.WriteLine(skill);
//                    }

//                }

//                } 
//            GetSkills("hareem");


//        Mobiles mobile = new Mobiles();
//        mobile.calling();

//        Mobiles apple = new Mobiles("apple");
//       apple.app();

//        Mobiles samsung = new Mobiles("samsung","S24");
//       samsung.sam();

//        Mobiles redmi = new Mobiles("redmi", "9C", 45000) ;
//        redmi.red();

//        Mobiles tecno = new Mobiles("tecno", "spark7", 35000 , true);
//       tecno.tec();
//    }
//    //class
//    public class Mobiles
//    {
//        public string? brand;
//        public string? model;
//        public int? price;
//        public bool isapproved;
//        //constructor
//        public Mobiles()
//        {
//            this.brand = "unknown";
//            this.model = "unknown";
//            this.price = 0;
//            this.isapproved = true;

//        }
//        //parametrized constructor
//        public Mobiles(string brand) {
//            this.brand = "samsung";
//            this.model = "unknown";
//            this.price = 0;
//            this.isapproved = true;

//        }
//        public Mobiles(string brand,string model)
//        {
//            this.brand = "samsung";
//            this.model = "S24";
//            this.price = 0;
//            this.isapproved = true;

//        }
//        public Mobiles(string brand, string model,int price)
//        {
//            this.brand = "samsung";
//            this.model = "S24";
//            this.price = 35000;
//            this.isapproved = true;

//        }
//        public Mobiles(string brand, string model, int price, bool isapproved)
//        {
//            this.brand = "samsung";     
//            this.model = "S24";
//            this.price = 35000;
//            this.isapproved = true;

//        }
//        //function
//        public void calling()
//        {
//           Console.WriteLine(this.model +" is calling");

//        }
//        public void app()
//        {
//            Console.WriteLine(this.brand);

//        }
//        public void sam()
//        {
//            Console.WriteLine(this.brand + " " + this.model );

//        }
//        public void red()
//        {
//            Console.WriteLine(this.brand+ " " + this.model + " " + this.price);

//        }
//        public void tec()
//        {
//            Console.WriteLine(this.brand + " " + this.model + " " + this.price + " " + this.isapproved);

//        }
//    }
//} 
//   }

//OOP
//            Watch Casio = new Watch("Casio 4571", "titanium black", 15000);
//            Casio.ShowTime();

//            SmartWatch AppleWatch = new SmartWatch("series9", "black", 15000, true, "Super Amoled", "500 mah");
//            AppleWatch.ShowTime();

//Jwellerywatch jw = new Jwellerywatch("diamond watch", "golden", 250000, true, "Super Amoled", "500 mah",true,"best");
//jw.ShowTime();

//jw.ShowTime("abc");
////Parent Class
//public class Watch
//        {
//            public string model;
//            public string color;
//            public int price;
//            public Watch(string model, string color, int price) {
//                this.model = model;
//                this.color = color;
//                this.price = price;
//            }
//            public void ShowTime()
//            {
//                Console.WriteLine($"{this.model} shows time in 24 hours format {DateTime.Now}.");
//            }

//        }  
////Child Class
//        public class SmartWatch : Watch
//        {
//            public bool canCall;
//            public string displayType;
//            public string battery;

//            public SmartWatch(string model, string color, int price, bool canCall, string displayType, string battery) : base(model, color, price)
//            {
//                this.canCall = canCall;
//                this.displayType = displayType;
//                this.battery = battery;
//            }
//            //Method Overriding
//            public void ShowTime()
//            {
//                Console.WriteLine($"{this.model} show time in all formats.Current date amnd time is:{DateTime.Now}.");
//            }
//    //Method Overloading
//    public void ShowTime(string region)
//    {
//        Console.WriteLine($"in{region}:{this.model} show time in all formats.Current date amnd time is:{DateTime.Now}.");
//    }
//}
////Child class
//public class Jwellerywatch : SmartWatch
//{
//    public bool diamond;
//    public string quality;

//    public Jwellerywatch(string model, string color, int price, bool canCall, string displayType, string battery, bool diamond, string quality) : base(model, color, price,canCall, displayType, battery)
//    {
//        this.diamond = diamond;
//        this.quality = quality;
//    }
//    //Method Overriding
//    public void ShowTime()
//    {
//        Console.WriteLine($"{this.quality} quality in Pakistan.");
//    }
//    //Method Overloading
//    public void ShowTime(string girls)
//    {
//        Console.WriteLine($"{girls}:{this.model} available for womens.");
//    }
//}



//ASSIGNMENT

//Car car1 = new Car(1, "AAZ-789", "Model S", "Tesla", 60000m);
//Bike bike1 = new Bike(2, "BBY-456", "CBR", "Honda", 15000m);
//HeavyVehicle hv1 = new HeavyVehicle(3, "CCX-123", "F-150", "Ford", 50000m);

//car1.PayTax();
//bike1.PayTax();
//hv1.PayTax();

//Console.WriteLine($"Total Vehicles: {ToolVehicle.TotalVehicles}");
//Console.WriteLine($"Total Tax Paying Vehicles: {ToolVehicle.TotalTaxPayingVehicles}");
//Console.WriteLine($"Total Non-Tax Paying Vehicles: {ToolVehicle.TotalNonTaxPayingVehicles}");
//Console.WriteLine($"Total Tax Collected: {ToolVehicle.TotalTaxCollected:C}");


//abstract public class ToolVehicle
//{
//    public int VehicleID;
//    public string RegNo;
//    public string Model;
//    public string Brand;
//    public decimal BasePrice;
//    public string VehicleType;

//    public static int TotalVehicles = 0;
//    public static int TotalTaxPayingVehicles = 0;
//    public static int TotalNonTaxPayingVehicles = 0;
//    public static decimal TotalTaxCollected = 0;

//    public ToolVehicle(int vehicleID, string regNo, string model, string brand, decimal basePrice, string vehicleType)
//    {
//        this.VehicleID = vehicleID;
//        this.RegNo = regNo;
//        this.Model = model;
//        this.Brand = brand;
//        this.BasePrice = basePrice;
//        this.VehicleType = vehicleType;
//        TotalVehicles++;
//    }

//    public abstract void PayTax();

//    public void PassWithoutPaying()
//    {
//        TotalNonTaxPayingVehicles++;
//        Console.WriteLine($"{VehicleType} {RegNo} passed without paying tax.");
//    }
//}

//public class Car : ToolVehicle
//{
//    public Car(int vehicleID, string regNo, string model, string brand, decimal basePrice)
//        : base(vehicleID, regNo, model, brand, basePrice, "Car") { }

//    public override void PayTax()
//    {
//        TotalTaxCollected += 2;
//        TotalTaxPayingVehicles++;
//        Console.WriteLine($"Car {RegNo} paid $2 tax.");
//    }
//}

//public class Bike : ToolVehicle
//{
//    public Bike(int vehicleID, string regNo, string model, string brand, decimal basePrice)
//        : base(vehicleID, regNo, model, brand, basePrice, "Bike") { }

//    public override void PayTax()
//    {
//        TotalTaxCollected += 1;
//        TotalTaxPayingVehicles++;
//        Console.WriteLine($"Bike {RegNo} paid $1 tax.");
//    }
//}

//public class HeavyVehicle : ToolVehicle
//{
//    public HeavyVehicle(int vehicleID, string regNo, string model, string brand, decimal basePrice)
//        : base(vehicleID, regNo, model, brand, basePrice, "Heavy Vehicle") { }

//    public override void PayTax()
//    {
//        TotalTaxCollected += 4;
//        TotalTaxPayingVehicles++;
//        Console.WriteLine($"Heavy Vehicle {RegNo} paid $4 tax.");
//    }
//}


//Getter Setter

//Students std1 = new Students();
//std1.name = "hareem";
//std1.Age = 45;
//Console.WriteLine(std1.name);
//public class Students
//{
//    public string name;
//    public string studentClass;
//    private int age;
//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if(value >= 25)
//            {
//                age = value;
//            }
//            else
//            {
//                age = 25;
//            }
//        }
//    }
//}

//Auto Complete Property

//Students std1 = new Students();
//std1.name = "hareem";
//std1.studentClass = "9";
//Console.WriteLine(std1.studentClass);
//public class Students
//{
//    public string? name;
//    public string? studentClass { get; set; }

//}


//enum
Console.WriteLine("enter day");
int input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case (int)Days.monday:
        Console.WriteLine("today is monday");
        break;
    case (int)Days.tuesday:
        Console.WriteLine("today is tuesday");
        break;
    case (int)Days.wednesday:
        Console.WriteLine("today is wednesday");
        break;
    case (int)Days.thursday:
        Console.WriteLine("today is thursday");
        break;
    case (int)Days.friday:
        Console.WriteLine("today is friday");
        break;
    case (int)Days.saturday:
        Console.WriteLine("today is saturday");
        break;
    case (int)Days.sunday:
        Console.WriteLine("today is sunday");
        break;
    default:
        Console.WriteLine("invalid day");
        break;
}
enum Days
{
    monday = 1,
    tuesday = 2,
    wednesday = 3,
    thursday = 4,
    friday = 5,
    saturday = 6,
    sunday = 7,

}
