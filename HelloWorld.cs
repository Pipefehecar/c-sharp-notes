using System;
using System.Net.NetworkInformation;

namespace HelloWorld
{    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Display the string
            Console.WriteLine("Hello, World!");
            //! PRIMITIVE DATA TYPES
            string name = "John Doe";
            Console.WriteLine("Hello, " + name);
            int age = 27;
            Console.WriteLine("I am " + age + " years old");
            double height = 6.2;
            float weight = 185.5f;
            Console.WriteLine("I am " + height + " feet tall and weigh " + weight + " pounds");
            Console.WriteLine(age + height + weight);
            bool isMarried = false;
            Console.WriteLine("Am I married? " + isMarried  );
            dynamic x = 10;
            Console.WriteLine(x);
            x = "Hello";
            Console.WriteLine(x);
            var y = 20; // y is an integer, type inferred from the initial value
            //var = "World"; // This will give an error
            Console.WriteLine(y);
            //template string like in JavaScript or python f-string
            Console.WriteLine($"Hello, {name}! You are {age} years old. You are {height} feet tall and weigh {weight} pounds. Are you married? {isMarried}");
            const double Pi = 3.14159;
            Console.WriteLine(Pi);

            //! DATA STRUCTURES
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            numbers[0] = 10;
            Console.WriteLine(numbers[0]);

            var myDict = new Dictionary<string, int>{
                {"one", 1},
                {"two", 2},
                {"three", 3}
            };
            Console.WriteLine(myDict["one"]);
            var mySet = new HashSet<int>{1, 2, 3, 4, 5, 1};
            Console.WriteLine(mySet.Count);
            var myTuple = (1, "Hello", 3.14);
            Console.WriteLine(myTuple.Item2);

            //! BUCLES
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For loop");
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index] );
            }
            Console.WriteLine("Foreach loop");
            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myDict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //! CONDITIONALS
            age = 17;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a minor");
            }
            // ! FUNCTIONS
            Console.WriteLine(Add(5, 10));
            // ! CLASSES
            MyClass myClass = new MyClass(5, 10);
            Console.WriteLine(myClass.Add());
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        class MyClass
        {
            public int x ;
            public int y;
            public MyClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int Add()
            {
                return x + y;
            }
        }
    }
}




