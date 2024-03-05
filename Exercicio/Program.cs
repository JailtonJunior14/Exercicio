using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario: ");
             double salarioB = double.Parse(Console.ReadLine());
            Console.WriteLine("Vale alimentação: ");
             double  valeA = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor por filho: ");
             double valeF = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero de filhos: ");
             double Nfilhos = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora: ");
             double Vhora = double.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas: ");
             double hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Desconto INSS: ");
             double inss = double.Parse(Console.ReadLine());
            Console.WriteLine("IRPF: ");
             double irpf = double.Parse(Console.ReadLine());
            double salarioL = (salarioB + valeA + (valeF * Nfilhos) + (Vhora * hora) - (inss + irpf));
            Console.WriteLine("Salario Liquido: R$: " + salarioL);
            Console.ReadKey();

        }
    }
}
