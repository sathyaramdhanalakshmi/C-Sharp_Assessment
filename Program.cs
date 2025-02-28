using OopsConcepts;
using System;
//using static OopsConcepts.PlayMusic;

class Program
{
    static void Main()
    {
        //1.BankAccount
        //BankAccount myAccount = new BankAccount(1000); 
        //myAccount.DisplayBalance();
        //myAccount.Deposit(500);
        //myAccount.Withdraw(300);
        //myAccount.Withdraw(1500); 


        //2.Data Hiding with Properties
        //try
        //{
        //    Student student = new Student();
        //    student.Name = "John Doe";
        //    student.RollNo = 101;
        //    student.DisplayDetails();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}


        //3.constructor overloading in a library system
        //Book book1 = new Book();
        //book1.DisplayDetails();

        //Book book2 = new Book("moon", "mary");
        //book2.DisplayDetails();

        //Book book3 = new Book("1964", "jenny", "123-4567891234");
        //book3.DisplayDetails();


        //4.Abstraction with Abstract class
        //Shape circle = new Circle(5);
        //Shape rectangle = new Rectangle(4, 6);

        //Console.WriteLine("Circle Area: " + circle.CalculateArea());
        //Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());


        //5.Method overriding for vechile system
        //Vehicle mycar = new Car();
        //mycar.Start(); // Calls Car's Start method

        //Vehicle mybike = new Bike();
        //mybike.Start(); // Calls Bike's Start method


        //6.Using Virtual Methods in Inheritance
        //Person person1 = new Student1("Alice", 20, "S123");
        //Person person2 = new Teacher("Mr. Bob", 40, "Mathematics");

        //person1.GetDetails();
        //person2.GetDetails();


        //7.Method Overloading in a Calculator Class
        //Calculator calc = new Calculator();

        //Console.WriteLine("Add two integers: " + calc.Add(2, 18));
        //Console.WriteLine("Add three integers: " + calc.Add(10, 20, 30));
        //Console.WriteLine("Add two doubles: " + calc.Add(5.2, 1.5));


        //8.Interface Implementation Challenge
        //IPlayable music = new MusicPlayer();
        //IPlayable video = new VideoPlayer();

        //music.Play();
        //video.Play();


        //9.Multiple Inheritance Using Interfaces
        //Report report = new Report("This is the annual report.");

        //report.Print();
        //report.SaveToFile("report.txt");



        //10.Design a Role-Based Access System
        //User admin = new Admin("Alice");
        //User customer = new Customer("Bob");

        //Console.WriteLine($"{admin.Username} ({admin.Role}):");
        //admin.AccessControl();

        //Console.WriteLine($"{customer.Username} ({customer.Role}):");
        //customer.AccessControl();




        //11.Operator Overloading for Complex Numbers
        //ComplexNumber c1 = new ComplexNumber(3, 4);
        //ComplexNumber c2 = new ComplexNumber(1, 2);

        //ComplexNumber result = c1 + c2;

        //Console.WriteLine("Sum: " + result);


        //12.Shallow Copy vs. Deep Copy
        //Department dept1 = new Department("IT", "Alice");
        //Department shallowCopy = dept1.ShallowCopy();
        //Department deepCopy = dept1.DeepCopy();

        //dept1.Manager.Name = "Bob";

        //Console.WriteLine("Original Dept Manager: " + dept1.Manager.Name);
        //Console.WriteLine("Shallow Copy Dept Manager: " + shallowCopy.Manager.Name);
        //Console.WriteLine("Deep Copy Dept Manager: " + deepCopy.Manager.Name);


        //13.Static Members in a Banking System
        //Bank acc1 = new Bank("Alice", 1000);
        //Bank acc2 = new Bank("Bob", 2000);

        //Console.WriteLine("Before changing interest rate:");
        //acc1.DisplayAccountInfo();
        //acc2.DisplayAccountInfo();

        //Bank.SetInterestRate(6.5); 

        //Console.WriteLine("\nAfter changing interest rate:");
        //acc1.DisplayAccountInfo();
        //acc2.DisplayAccountInfo();


        //14.Sealed Class in a Security System
        //SecuritySystem security = new SecuritySystem();
        //security.AuthenticateUser("admin", "password123");
        //security.AuthenticateUser("user", "wrongpass");


        //15.Use of Delegates for Event Handling
        //Button button = new Button();
        //button.OnClick += ButtonClicked;
        //button.Click();






        //16.Factory Pattern for Object Creation
        //Console.Write("Enter vehicle type (Car/Bike): ");
        //string type = Console.ReadLine();

        //try
        //{
        //    IVehicle vehicle = VehicleFactory.GetVehicle(type);
        //    vehicle.Drive();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}



        //17.Decorator Pattern in a Logger System
        //ILogger logger = new FileLogger();
        //ILogger timestampLogger = new TimestampLogger(logger);
        //ILogger errorLogger = new ErrorCategoryLogger(timestampLogger, "ERROR");

        //Console.WriteLine("Basic Logging:");
        //logger.Log("This is a log message.");

        //Console.WriteLine("\nLogging with Timestamp:");
        //timestampLogger.Log("This is a log message with timestamp.");

        //Console.WriteLine("\nLogging with Timestamp and Error Category:");
        //errorLogger.Log("This ia an error Message.");



        //18.Thread-Safe Singleton Pattern for Configuration Management
        //ConfigurationManager config1 = ConfigurationManager.GetInstance();
        //config1.ShowConfig();

        //ConfigurationManager config2 = ConfigurationManager.GetInstance();
        //config2.SetConfig("Updated Configuration");

        //config1.ShowConfig();
        //config2.ShowConfig();

        //Console.WriteLine(ReferenceEquals(config1, config2));



        //19.Real-World Observer Pattern for Notifications
        //NotificationService notificationService = new NotificationService();

        //EmailNotifier emailNotifier = new EmailNotifier();
        //SMSNotifier smsNotifier = new SMSNotifier();

        //notificationService.AddObserver(emailNotifier);
        //notificationService.AddObserver(smsNotifier);

        //Console.WriteLine("Sending Notification...");
        //notificationService.NotifyObservers("New message received!");

        //Console.WriteLine("Removing Email Notifier...");
        //notificationService.RemoveObserver(emailNotifier);

        //Console.WriteLine("Sending Another Notification...");
        //notificationService.NotifyObservers("Another update!");

        //Console.ReadLine();



        //20.Strategy Pattern for Dynamic Discount Calculation
        ShoppingCart cart = new ShoppingCart();
        Console.WriteLine("Enter total amount:");
        double total = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose discount type: 1 - No Discount, 2 - Percentage, 3 - Fixed Amount");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                cart.SetDiscountStrategy(new NoDiscount());
                break;
            case 2:
                Console.WriteLine("Enter discount percentage:");
                double percentage = Convert.ToDouble(Console.ReadLine());
                cart.SetDiscountStrategy(new PercentageDiscount(percentage));
                break;
            case 3:
                Console.WriteLine("Enter fixed discount amount:");
                double amount = Convert.ToDouble(Console.ReadLine());
                cart.SetDiscountStrategy(new FixedAmountDiscount(amount));
                break;
            default:
                Console.WriteLine("Invalid choice, applying no discount.");
                cart.SetDiscountStrategy(new NoDiscount());
                break;
        }

        double finalAmount = cart.CalculateFinalAmount(total);
        Console.WriteLine($"Final amount after discount: {finalAmount}");



    }
    //15.Use of Delegates for Event Handling
    //static void ButtonClicked()
    //{
    //    Console.WriteLine("Event Handler: Button was clicked.");
    //}
}
