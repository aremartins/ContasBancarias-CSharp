using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Byte Bank!=================");

          try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");

                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }

            Console.ReadLine();


        }
    }
}
