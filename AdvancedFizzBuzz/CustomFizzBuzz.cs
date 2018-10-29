using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzReference = SuperFizzBuzz;

namespace AdvancedFizzBuzz
{
    class CustomFizzBuzz
    {
        private static FizzBuzzReference.IFizzBuzzModel GetFizzBuzzModel;

        private static List<FizzBuzzReference.NumTokenPair> advancedNumTokenPair = new List<FizzBuzzReference.NumTokenPair>()
        {
            new FizzBuzzReference.NumTokenPair(3, "Fizz"),
            new FizzBuzzReference.NumTokenPair(5, "Buzz"),
            new FizzBuzzReference.NumTokenPair(38, "Bazz")
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Advanced Fizz Buzz: ");
            GetFizzBuzzModel = new FizzBuzzReference.FizzBuzzModel(advancedNumTokenPair);

            var result = new StringBuilder();
            for (int i = -12; i <= 145; i++) {
                result.AppendFormat("{0} \n", GetFizzBuzzModel.Process(i));
            }
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
