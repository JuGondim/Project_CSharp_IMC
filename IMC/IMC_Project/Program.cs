using System;

namespace IMC_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome? ");
            String nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual sua altura? ");
            float alt = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual seu peso? ");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            float imc = peso / (alt * alt);

            if (imc < 17)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está muito abaixo do peso!");
            }
            else if (imc > 17 && imc < 18.49)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (imc > 18.49 && imc < 24.99)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Seu peso está normal! :)");
            }
            else if (imc > 25 && imc < 29.99)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está acima do peso!");
            }
            else if (imc > 30 && imc < 34.99)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está muito acima do peso! :(");
            }
        }
    }
}
