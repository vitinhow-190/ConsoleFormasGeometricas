using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a forma geometrica desejada (Quadrado,Trapézio,Losando,Retângulo): ");
            string forma = Console.ReadLine();

            switch (forma)
            {
                case "Quadrado":
                    Console.WriteLine("Informe a medida da base: ");
                    double B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a medida da altura");
                    double H = double.Parse(Console.ReadLine());

                    double area;

                    area = B * H;

                    Console.WriteLine("A área do Quadrado é: " + area);
                break;

                case "Retângulo":
                    Console.WriteLine("Informe a medida da base: ");
                    double R = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a medida da altura");
                    double R2 = double.Parse(Console.ReadLine());

                    double arearet;

                    arearet = R * R2;

                    Console.WriteLine("A área do Quadrado é: " + arearet);
                break;

                case "Trapézio":
                    Console.WriteLine("Informe a medida da base: ");
                    double T = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a medida da base: ");
                    double T1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a medida da altura");
                    double TH = double.Parse(Console.ReadLine());

                    double areatra;

                    areatra = (T + T1) * TH / 2;

                    Console.WriteLine("A área do Quadrado é: " + areatra);
                break;

                case "Losango":
                    Console.WriteLine("Informe a medida da diagonal maior: ");
                    double L = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a medida da diagonal menor: ");
                    double L1 = double.Parse(Console.ReadLine());


                    double arealo;

                    arealo = (L * L1) / 2;

                    Console.WriteLine("A área do Quadrado é: " + arealo);
                break;
               
                    
            }
            Console.ReadKey();

        }
    }
}
