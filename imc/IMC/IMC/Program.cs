using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe seu peso: ");
            float wheight = (float)Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Informe sua altura: ");
            float hight = (float)Convert.ToDouble(Console.ReadLine());

            float result = wheight / (hight * hight);

            if ( result <= 18.5 ) {
                Console.WriteLine("Olá, " + name + " Você está abaixo do peso");
            } else if ( result > 18.5 && result < 25) {
                Console.WriteLine("Olá, " + name + " Peso dentro da normalidade");
            } else if ( result >= 25 && result < 30) {
                Console.WriteLine("Olá, " + name + " Você está acima do peso");
            } else if ( result >= 30 && result < 35) {
                Console.WriteLine("Olá, " + name + " Obesidade grau I");
            } else if ( result >= 35 && result < 40) {
                Console.WriteLine("Olá, " + name + " Obesidade grau II");
            } else if ( result >= 40 ) {
                Console.WriteLine("Olá, " + name + " Obesidade grau III");
            }
        }
    }
}
