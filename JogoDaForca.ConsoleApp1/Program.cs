namespace JogoDaForca.ConsoleApp1
{
    internal class Program
    {
        //Versão 1: Estrutura básica e entrada do usuário 
        // Versão 2: Exibir palavra oculta com traços 
        //Versão 3: Verificação do input, ou entrada de dados
        static void Main(string[] args)
        {
            while (true)
            {
                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length]; 

                for(int caractere = 0; caractere < letrasEncontradas.Length; caractere++ )
                {
                    //acessar o array no indice 0 ou encontrado // quando se quer passar valor para a caractere// [caractere] = '_';//
                    letrasEncontradas[caractere] = '_';
                }
                int quantidadeErros = 0;
                bool jgadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = String.Join(" ", letrasEncontradas); //join== juntar caractere separadas ou strings // separador das caracteres unicas= String.Join(" ",  letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Jogo da forca");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                    Console.WriteLine("-------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]; // apena um caracter do q o usuario digita

                    for ( int contador = 0; contador < palavraSecreta.Length; contador++ )
                    {
                        char letraAtual = palavraSecreta[contador];

                        if(chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                        }
                    }

                    Console.WriteLine(chute);
                    Console.ReadLine();
                } while (jogadorAcertou == false && jgadorEnforcou == false); // (|| = ou) && so vai ser verdadeiro quando as duas forem verdadeiras

             
            }
        }
           
    }
}
