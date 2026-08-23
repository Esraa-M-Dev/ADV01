namespace AssigmnentAdvancedC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region generic class
            //Q1:Generic Class:class works with general/different types of its members instead of build more than class
            //compiler will resolve type while creating the object

            //used to :1-Type safety(compile detection not in run time)
            // 2-avoid boxing and un boxing
            //  3-resuability and maintainability
            //  4-gained control

            //Q2:Container generic class
            //Container<int> c1 = new();
            //c1.Add(5);
            //Console.WriteLine(c1.Get());
            //Container<string> c2 = new();
            //c2.Add("esraa");
            //Console.WriteLine(c2.Get());
            #endregion
            #region multi type parameter
            // Q3://Different Types of Different Parameters in Generic Class
            //suitable for changing request
            //Pair<int, string> p1 = new(0, "esraa");
            //Console.WriteLine(p1);
            //Pair<int, bool> p2 = new(1, false);
            //Console.WriteLine(p2);
            #endregion
            #region generic method
            //Q4:Swap
            //generic method:method works eith general type instead of method overloading
            //class may be non generic,type defined across specific method
            //compiler will resolve type while calling method
            //int x = 5, y = 4;
            //Console.WriteLine("Before swap");
            //Console.WriteLine($"x= {x} ,y={y}");
            //Utility.Swap<int>(ref x, ref y);
            //Console.WriteLine("after swap");
            //Console.WriteLine($"x= {x},y={y}");

            //Console.WriteLine("==========================");

            //string c = "esraa", d = "salma";
            //Console.WriteLine("Before swap");
            //Console.WriteLine($"c= {c} ,d={d}");
            //Utility.Swap<string>(ref c, ref d); 
            //Console.WriteLine("after swap");
            //Console.WriteLine($"c= {c},d={d}");

            //Q5:FindMax

            //int[] items = { 1, 2 };
            //Console.WriteLine(Utility.FindMax(items)); 

            //with string
            //string[] items = { "esraa", "salma", "rawan" };
            //Console.WriteLine(Utility.FindMax(items)); 
            #endregion
            #region generic interface
            //Q6:Generic interface:interface works with different types of classes
            //T classes implement interface
            //ProductRepository productRepository = new ProductRepository();
            //productRepository.Create(new Product(1, "Tv", 7000));
            //productRepository.Create(new Product(2, "Pc", 10000));
            //productRepository.Create(new Product(3, "Ac", 20000));
            //List<Product> currentProducts = productRepository.GetAll();
            //foreach (Product product in currentProducts)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine("last product in list");
            //Product lastProduct = productRepository.GetById(2);
            //Console.WriteLine(lastProduct);

            //productRepository.Delete(2);
            //Console.WriteLine("after removing");
            //foreach (Product product in currentProducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region generic constraints
            //Q7:struct constraint:force the type of class members to be from struct type[int,float,....]
            //Container<int> c1 = new();
            //Container<string> c2 = new(); //compile error
            //Q8:class constraint:force the type of class members to be from class type{string,......]
            //Container<string> c2 = new();

            //Q9new constraint:force the type created as object from class to have parameterless constructor
            // Factory<Person> factory = new();
            // Person p = factory.Create();

            //Q10:interface constraint:any generic type of class must implement interface
            //Test<Book> test = new Test<Book>();

            //Book book = new Book();

            //test.PrintItem(book);

            //Q11:base constraint:generic Type must inherit from specific class
            // Shelter<Dog> shelter = new Shelter<Dog>();

            #endregion
        }
    }
}
