
namespace MyApp // Note: actual namespace depends on the project name.
{
    class Animal
    {
        //private int Name;

        //public string Name
        //{
        //    get { return Name; }
        //    set
        //    {
        //        Console.WriteLine("Enter Name: ");
        //        Name = Console.ReadLine();

        //    }
        //}
        private string Name;
        public string Names
        {
            get { return Name; }
            set
            {
                Console.Write("Enter Name: ");
                Name = Console.ReadLine();
            }
        }
        private int ages;
        public int Age
        {
            get { return ages; }
            set
            {
                Console.Write("Enter Age: ");
                ages = Convert.ToInt32(Console.ReadLine()); }
        }
        private string colors;
        public string Color
        {
            get { return colors; }
            set {
                Console.Write("Enter Color: ");
                colors = Console.ReadLine();
            }
        }

        public int Energy { get; set; }
        private int Prices;

        public int Price
        {
            get { return Prices; }
            set { 
                Console.Write("Enter Prices: ");
                Prices = Convert.ToInt32(Console.ReadLine());
            }
        }

        public int MealQuantity { get; set; }
        public Animal()
        {
            Age = default;
            Color = default;
            Names = default;
            Energy = 20;
            MealQuantity = 100;
            Price = default;
            Start();
        }
        public void Start()
        {
            while (Age!=100)
            {

                Console.Write("Enter: ");
                var number = Console.ReadLine();
                if (Energy == 10)
                {
                    Sleeps();
                }
                else if (number == "1")
                {
                    Energy -= 10;
                }
                else if (number == "2")
                {
                    MealQuantity -= 10;
                    Energy += 10;
                }
                Thread.Sleep(1000);
                Console.Clear();
                Cout();
            }
        }
        virtual public void Eat() => Console.WriteLine("Base eat");
        public void Cout()
        {
            Console.WriteLine($"Name {Name}\nColor {colors}\nAge {Age}\nPrice {Price}\nEnergy{Energy}");
        }
        public void Sleeps()
        {
            Energy = 100;
            Prices+=55;
            ages++;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Z");
               for(int j = 0; j <5; j++)
               {
                    Console.Write(".");
                    Thread.Sleep(250);
               }
            }
            Thread.Sleep(1000);
        }
    }

    //class Cat : Animal
    //{
    //    // public string AnyPropertyForDog { get; }
    //    public string AnyPropertyForDog => "ForDog"; // Only Get (Property)

    //    public void Bark() => Console.WriteLine("bark...");
    //    public void Run() => Console.WriteLine("Run...");

    //    // public new void Sleep() => Console.WriteLine("Dog Sleep");
    //    public override void Sleep() => Console.WriteLine("car Sleep");
    //    public override void Eat() => Console.WriteLine("Cat Eat");
    //}

    class Dog : Animal
    {
        // public string AnyPropertyForDog { get; }
        public string AnyPropertyForDog => "ForDog"; // Only Get (Property)
       
        public void Bark() => Console.WriteLine("bark...");
        public void Run() => Console.WriteLine("Run...");

        // public new void Sleep() => Console.WriteLine("Dog Sleep");
       // public override void Sleep() => Console.WriteLine("Dog Sleep");
        public override void Eat() => Console.WriteLine("Dog Eat");
    }


    //class Bird : Animal
    //{
    //    public float Duration { get; set; } = 1.0f;
    //    public void Fly() => Console.WriteLine("Fly...");

    //    public override void Sleep() => Console.WriteLine("Bird Sleep");
    //    public override void Eat() => Console.WriteLine("Bird Eat");
    //}


    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Animal[] animals =
            {
                    new Dog()
                    //new Bird { Age =2, Color ="White", Name = "Zippy", Duration = 7.5f}
            };
            //var d = new Dog { Age = 1, Color = "Black", Name = "Toplan" };
            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal);
            //    //animal.Sleep();
            //}
        }
    }

}
