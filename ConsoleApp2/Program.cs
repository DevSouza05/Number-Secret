using System.Globalization;

namespace Jogo
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Digite um numero de um 1 a 10");
            Random aleatorio = new Random();
           
            bool acertou = false;

                int numeroSecreto = aleatorio.Next(1, 10);
            do 
            {
                int chute = int.Parse(Console.ReadLine());

                if (chute == numeroSecreto)
                {
                    Console.Write("Parabens você acertou !! ");
                     Console.Write("O numero secreto é: " + numeroSecreto);

                    acertou = true;
                }
                else
                    if( chute < numeroSecreto)
                    {
                        Console.WriteLine(" Errou! O número é secreto é maior");
                       
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor");
                       

                    }
            }
            while (!acertou);
        }
    }
}