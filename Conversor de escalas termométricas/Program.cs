using System;

namespace Nova_pasta__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("-------->>>>>>>  Conversor de Temperaturas  <<<<<<<--------");
            Console.WriteLine("               Qual conversão deseja fazer?");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" (1) - Celsius -> Fahrenheit");
            Console.WriteLine(" (2) - Celsius -> Kelvin");
            Console.WriteLine(" (3) - Fahrenheit -> Celsius");
            Console.WriteLine(" (4) - Fahrenheit -> Kelvin");
            Console.WriteLine(" (5) - Kelvin -> Fahrenheit");
            Console.WriteLine(" (6) - Kelvin -> Celsius");
            Console.WriteLine(" (7) - SAIR");
            Console.WriteLine("Selecione o numero correspondente a sua opção: ");

            int option = Convert.ToInt16(Console.ReadLine());
            switch(option){
                case 1:
                cel_fah();
                break;
   
                case 2:
                cel_kel();
                break;
   
                case 3:
                fah_cel();
                break;
   
                case 4:
                fah_kel();
                break;
   
                case 5:
                kel_fah();
                break;
   
                case 6:
                kel_cel();
                break;

                case 7:
                Environment.Exit(1);            
                break;

                default:
                Console.WriteLine("Número inválido");
                return;
                
            }
           
            }
            

            static void cel_fah()
            {
                Console.WriteLine("Informe a temperatura em Celsius");
                double temp_cel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"A temperatura em Fahrenheit é {temp_cel * 1.8 + 32}");
                Console.ReadKey();
                return;
            }
            

            static void cel_kel()
            {
                Console.WriteLine("Informe a temperatura em Celsius");
                double temp_cel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"A temperatura em Kelvin é {temp_cel + 273}");
                Console.ReadKey();
                return;
            }


            static void fah_cel()
            {
                Console.WriteLine("Informe a temperatura em Fahrenheit");
                double temp_fah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"A temperatura em Celsius é {(temp_fah - 32) / 1.8}");
                Console.ReadKey();
                return;
            }


            static void fah_kel()
            {
                Console.WriteLine("Informe a temperatura em Fahrenheit");
                double temp_fah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"A temperatura em Kelvin é {((temp_fah - 32) / 1.8) + 273}");
                Console.ReadKey();
                return;
            }


            static void kel_cel()
            {
                Console.WriteLine("Informe a temperatura em Kelvin");
                double temp_kel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"A temperatura em Celsius é {temp_kel - 273}");
                Console.ReadKey();
                return;
            }


            static void kel_fah()
            {
                Console.WriteLine("Informe a temperatura em Kelvin");
                double temp_kel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"A temperatura em Fahrenheit é {temp_kel * 1.8 - 459.67}");
                Console.ReadKey();
                return;
            }

            

        }
   
    }
}