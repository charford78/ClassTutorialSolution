using System;

namespace ClassTutorial {
    class Program {
        static void Main(string[] args) {

            var fred = new Student();
            fred.Name = "Fred";
            fred.SAT = 1000;
            var wilma = new Student();
            wilma.Name = "Wilma";
            wilma.SAT = 2000;
            
            var message = wilma.Print(1);
            Console.WriteLine(message);

            message = fred.Print(2);
            Console.WriteLine(message);

            var barney = new Student();
            barney.Name = "Barney";
            barney.SAT = 1200;
            wilma.Print(1);
            fred.Print(2);
            barney.Print(3);
            barney.SAT = barney.SAT + 20;
            barney.Print(4);

            var mathlib = new MathLib();
            var nbr1 = 10;
            var nbr2 = 4;
            var result = mathlib.Add(nbr1, nbr2);
            Console.WriteLine($"The sum is {result}");
            result = mathlib.Sub(nbr1, nbr2);
            Console.WriteLine($"The difference is {result}");
            result = mathlib.Mult(nbr1, nbr2);
            Console.WriteLine($"The product is {result}");
            result = mathlib.Div(nbr1, nbr2);
            Console.WriteLine($"The quotient is {result}");
            result = mathlib.Mod(nbr1, nbr2);
            Console.WriteLine($"The remainder is {result}");
        }
    }
}
