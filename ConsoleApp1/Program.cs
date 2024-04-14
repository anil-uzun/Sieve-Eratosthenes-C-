using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

//SieveEratosthenes(onePara)
namespace ConsoleApp1
{
    internal class Program
        {
        static void Main(string[] args)
        {
            List<Int32> primeNums = new List<Int32>(Enumerable.Range(2,99));
            primes(2,100,primeNums);
            write2file(primeNums);
        }
        static void primes(int start ,int range, List<Int32> primeNums) {
            foreach(Int16 num in Enumerable.Range(start, range)) {
                if(num > start && ((num % start) == 0)) {
                    primeNums.Remove(num);
                }
            }
            if (start != 100) {
                primes(start+1,100,primeNums);
            }
        }
        static private void write2file(List<int> value)
        {
            StreamWriter writer = new StreamWriter("c:\\primeNums.txt");
            foreach(int num in value) {
                writer.WriteLine("{0}",num);
            }
            writer.Close();
        }
    }
}