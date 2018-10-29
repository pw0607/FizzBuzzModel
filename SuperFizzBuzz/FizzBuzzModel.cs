using System;
using System.Collections.Generic;
using System.Text;


namespace SuperFizzBuzz
{
    public class FizzBuzzModel : IFizzBuzzModel
    {
        public FizzBuzzModel() {
            NumTokenPairs = new List<NumTokenPair> {
                new NumTokenPair(3, "Fizz"),
                new NumTokenPair(5, "Buzz")
            };
        }

        public FizzBuzzModel(List<NumTokenPair> newNumTokenPair) {
            NumTokenPairs = newNumTokenPair ?? throw new InvalidProgramException("Invlid input");
        }
        public string Process(int value){
            var result = new StringBuilder();
            foreach (var eachPair in NumTokenPairs){
                if (value % eachPair.Num == 0)
                    result.Append(eachPair.Token);
            }
            if (result.Length > 0)
                return result.ToString();
            return value.ToString();
        }
        private List<NumTokenPair> NumTokenPairs { get; set; }
        
            
    }
    public interface IFizzBuzzModel {
        string Process(int value);
    }

    public class NumTokenPair
    {
        public NumTokenPair(int num, string token)
        {
            if (num == 0 || token == null)
                throw new InvalidOperationException("Invalid input");
            Num = num;
            Token = token;
        }
        public int Num { get; private set; }
        public string Token { get; private set; }
    }
}
