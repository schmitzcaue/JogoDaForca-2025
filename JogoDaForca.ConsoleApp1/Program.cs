namespace JogoDaForca.ConsoleApp1
{
    internal class Program
    {
        //Versão 1: Estrutura básica e entrada do usuário 
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Jogo da forca");
                Console.WriteLine("-------------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0] ; // apena um caracter do q o usuario digita

                Console.WriteLine(chute);

                Console.ReadLine();
            }
        }
           
    }
}
