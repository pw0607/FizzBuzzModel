using System;
using System.Text;
using FizzBuzzReference = SuperFizzBuzz;


namespace ClassicFizzBuzz
{
    class DefaultFizzBuzz
    {
        private static FizzBuzzReference.IFizzBuzzModel GetFizzBuzzModel;
        static void Main(string[] args)
        {
            Console.WriteLine("Classic Fizz Buzz: ");
            GetFizzBuzzModel = new FizzBuzzReference.FizzBuzzModel();
            var result = new StringBuilder();

            for (int i = 1; i <= 100; i++) {
                result.AppendFormat("{0} \n", GetFizzBuzzModel.Process(i));
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
