using System;

namespace JogoDaForca.ConsoleApp1
{
    internal class Program
    {
        //Versão 1: Estrutura básica e entrada do usuário 
        // Versão 2: Exibir palavra oculta com traços 
        //Versão 3: Verificação do input, ou entrada de dados
        //acessar o array no indice 0
        //Versão 4: Exibir boneco da forca 
        //Versão 5: Escolher uma palavra aleatória
        //Armazenar e exibir letras ja digitadas
        static void Main(string[] args)
        {
            string[] frutas = [
             
            "ABACATE",
            "ABACAXI",
            "ACEROLA",
            "ACAI",
            "ARACA",
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJA",
            "CAJU",
            "CARAMBOLA",
            "CUPUACU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MACA",
            "MANGABA",
            "MANGA",
            "MARACUJA",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA"
        ];

            while (true)
            {

                Random geradorDeNumeros = new Random();
                // valore3s aleatorios
                 int indicePalvraEscolhida = geradorDeNumeros.Next(frutas.Length);
                int[] memoria = new int[5];

                string palavraSecreta = frutas[indicePalvraEscolhida];

                char[] letrasEncontradas = new char[palavraSecreta.Length]; 

                for(int caractere = 0; caractere < letrasEncontradas.Length; caractere++ )
                {
                    //acessar o array no indice 0 ou encontrado // quando se quer passar valor para a caractere// [caractere] = '_';//
                    letrasEncontradas[caractere] = '_';
                }

                int quantidadeErros = 0;
                bool jgadorEnforcou = false;
                bool jogadorAcertou = false;

               





                //////////////
                    do
                    {
                    string dicaDaPalavra = String.Join(" ", letrasEncontradas); //join== juntar caractere separadas ou strings // separador das caracteres unicas= String.Join(" ",  letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Jogo da forca");
                    Console.WriteLine("-------------------------------------");

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
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("quantidade de erros: " + quantidadeErros);
                    Console.WriteLine("-------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]; // apena um caracter do q o usuario digita


                    ////////////////////////// 
                    int memoria = 0;
                    int[] memoria == chute ;
                    int numeroDigitado = 0;

                    if (memoria.Contains(numeroDigitado))
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Voce já usou essa tentativa!");
                        Console.WriteLine("-------------------------------------------");
                    }


                    //////////////////
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

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

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

                } while (jogadorAcertou == false && jgadorEnforcou == false); // (|| = ou) && so vai ser verdadeiro quando as duas forem verdadeiras

               

                Console.ReadLine();
            }
        }
           
    }
}
