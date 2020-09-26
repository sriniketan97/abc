using System;

namespace PrimeNumber{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool result = Check_Prime(number);
            if (result == false){
                Console.WriteLine("nonPrime");
            }
            else{
                 Console.WriteLine("Prime");
            }           
            Console.Read();
        } 

        private static bool Check_Prime(int number){
            int i;
            for (i = 2; i <= number - 1; i++){
                if (number % i == 0){
                    return false;
                }
            }
            if (i == number){
                return true;
            }
            return false;
        }
    } 
}