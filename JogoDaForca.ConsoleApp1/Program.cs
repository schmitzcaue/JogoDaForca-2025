/* Versões
//Versão 1: Estrutura básica e entrada do usuário 
//Versão 2: Exibir palavra oculta com traços 
//Versão 3: Verificação do input, ou entrada de dados
//acessar o array no indice 0
//Versão 4: Exibir boneco da forca 
*/

namespace JogoDaForca.ConsoleApp1
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            while (true)
            {
                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];
                char[] letrasErradas = new char[5];
                int contadorLetrasErradas = 0;

                for(int caractere = 0; caractere < letrasEncontradas.Length; caractere++ )
                {
                    //acessar o array no indice 0 ou encontrado // quando se quer passar valor para a caractere// [caractere] = '_';//
                    letrasEncontradas[caractere] = '_';
                }

                for (int caractere = 0; caractere < letrasErradas.Length; caractere++)
                {
                    //acessar o array no indice 0 ou encontrado // quando se quer passar valor para a caractere// [caractere] = '_';//
                    letrasErradas[caractere] = '_';
                }

                int quantidadeErros = 0;
                bool jgadorEnforcou = false;
                bool jogadorAcertou = false;

                //declarar uma nova variável
                //string letrasErradas = "";


                do
                {
                    string dicaDaPalavra = String.Join(" ", letrasEncontradas); //join== juntar caractere separadas ou strings // separador das caracteres unicas= String.Join(" ",  letrasEncontradas);
                    string dicaLetrasErradas = String.Join(" ", letrasErradas);

                    #region escreve o cabeçalho do jogo

                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Jogo da forca");
                    Console.WriteLine("-------------------------------------");

                    #endregion

                    #region código que desenha a forca

                    if (quantidadeErros == 0)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 1)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         o         ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    
                    else if (quantidadeErros == 2)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         o         ");
                        Console.WriteLine(" |         x         ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    
                    else if (quantidadeErros == 3)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         o         ");
                        Console.WriteLine(" |        /x\\         ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    
                    else if (quantidadeErros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         o         ");
                        Console.WriteLine(" |        /x\\         ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    
                    else if (quantidadeErros == 5)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         o         ");
                        Console.WriteLine(" |        /x\\         ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\              ");
                        Console.WriteLine(" |        ---          ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    #endregion

                    #region código que apresenta a palavra secreta e qtd de erros
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                    Console.WriteLine("-------------------------------------");

                    Console.WriteLine("Letras erradas: " + dicaLetrasErradas);
                    Console.WriteLine("-------------------------------------");

                    Console.WriteLine("quantidade de erros: " + quantidadeErros);
                    Console.WriteLine("-------------------------------------");

                    #endregion

                    #region código que recebe o que o usuário informou (chute do usuário)

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]; // apena um caracter do q o usuario digita

                    #endregion

                    #region código que verifica se o usuário informou uma letra existente na palavra secreta
                    bool letraFoiEncontrada = false;

                    for ( int contador = 0; contador < palavraSecreta.Length; contador++ )
                    {
                        char letraAtual = palavraSecreta[contador];

                        if(chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                    }

                    #endregion
                                       
                    
                    if (letraFoiEncontrada == false)
                    {
                        quantidadeErros++;
                        //letrasErradas += chute + ", ";
                        letrasErradas[contadorLetrasErradas] = chute;
                        contadorLetrasErradas++;
                    }

                    //Console.WriteLine("Letras erradas: " + string.Join(" ", letrasErradas));

                    Console.ReadLine();

                    #region outros códigos 


                    dicaDaPalavra = String.Join("", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta; //true ou false
                    // o jogador podera cometer 5 erros antes de perder
                    jgadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Voce acertou a apalavra secreta! Era: " + palavraSecreta);
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (jgadorEnforcou)
                    {
                            Console.Clear();
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Jogo da forca");
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/        |        ");
                            Console.WriteLine(" |         o        ");
                            Console.WriteLine(" |        /x\\      ");
                            Console.WriteLine(" |         x        ");
                            Console.WriteLine(" |        / \\      ");
                            Console.WriteLine(" |        ---       ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Que azar, tente novamente! A palavra era: " + palavraSecreta);
                        Console.WriteLine("-------------------------------------");
                    }

                    #endregion 
                
                } while (jogadorAcertou == false && jgadorEnforcou == false); // (|| = ou) && so vai ser verdadeiro quando as duas forem verdadeiras

                Console.ReadLine();
            }
        }
           
    }
}
