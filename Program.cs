using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha, sair;

            try
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("*------Calculadora Turbo------*\n");

                    Console.WriteLine("*------Choose Your Destiny------*");
                    Console.WriteLine("Subtrair: -");
                    Console.WriteLine("Somar: +");
                    Console.WriteLine("Dividir: /");
                    Console.WriteLine("Multiplicar: *");
                    Console.WriteLine("Porcentagem: P");
                    Console.WriteLine("Radiação (Raiz Quadrada): R");
                    Console.WriteLine("Potencia: PO");
                    Console.WriteLine("Extra (cuidado): E\n");
                    Console.Write("Escolha a Operação que Deseja Utilizar: ");
                    escolha = Console.ReadLine().ToUpper();

                    if (escolha == "-")
                    {
                        Sub();
                    }

                    if (escolha == "+")
                    {
                        Soma();
                    }

                    if (escolha == "/")
                    {
                        Divi();
                    }

                    if (escolha == "*")
                    {
                        Multi();
                    }

                    if (escolha == "P")
                    {
                        Porcentagem();
                    }

                    if (escolha == "R")
                    {
                        Raiz();
                    }
                     if (escolha == "PO")
                    {
                        Potencia();
                    }
                     if (escolha == "E")
                     {
                        Extra();
                    }

                    Console.Write("Deseja Sair? S/N: ");
                    sair = Console.ReadLine().ToUpper();
                }
                while (sair != "S" && sair != "SIM");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Não se dividi por zero.");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Númeração incorreta.");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite um numero correto tente novamente.");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(); 
                Console.WriteLine($"Erro 404: {ex.Message}");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Obrigado por ser minha cobaia ");
        }
        static void Soma()
        {
            double soma1, soma2, somafinal;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Qual é o 1ºValor: ");
            soma1 = double.Parse(Console.ReadLine());

            Console.Write("Qual é  o 2ºValor: ");
            soma2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            somafinal = soma1 + soma2;
            Console.WriteLine($"A soma de {soma1} + {soma2} = {somafinal}");
            Console.ResetColor () ;
            Console.WriteLine();
        }

        static void Sub()
        {
            double sub1, sub2, subfinal;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Qual é o 1ºValor: ");
            sub1 = double.Parse(Console.ReadLine());

            Console.Write("Qual é o 2ºValor: ");
            sub2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            subfinal = sub1 - sub2;
            Console.WriteLine($"A subtração de {sub1} - {sub2} = {subfinal}");
            Console.ResetColor () ;
            Console.WriteLine();
        }

        static void Multi()
        {
            double multi1, multi2, multifinal;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Qual é o 1°valor : ");
            multi1 = double.Parse(Console.ReadLine());

            Console.Write("Qual é o 2ºValor: ");
            multi2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            multifinal = multi1 * multi2;
            Console.WriteLine($"A multiplicaçao de {multi1} * {multi2} = {multifinal}");
            Console.ResetColor () ;
            Console.WriteLine();
        }

        static void Divi()
        {
            double divi1, divi2, divifinal;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Qual é o seu dividendo: ");
            divi1 = double.Parse(Console.ReadLine());

            Console.Write("Qual é o seu divisor: ");
            divi2 = double.Parse(Console.ReadLine());

            if (divi2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }

            Console.WriteLine();
            divifinal = divi1 / divi2;

            Console.WriteLine($"A divisão de {divi1} / {divi2} = {divifinal}");
            Console.ResetColor () ;
            Console.WriteLine();
        }

        static void Porcentagem()
        {
            double p1, v1, p2, pfinal;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Qual a  Porcentagem desejada: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor base: ");
            v1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            p2 = p1  / 100;

            Console.WriteLine();
            pfinal = p2  * v1;

            Console.WriteLine($"O resultado de {p1} % de {v1} é = {pfinal}%");
            Console.ResetColor () ;
            Console.WriteLine();
        }

        static void Raiz()
        {
            double raizQ, resposta;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("A Raiz Quadrada de : ");
            raizQ = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resposta = Math.Sqrt(raizQ);
            Console.ResetColor () ;
            Console.WriteLine($"A raiz de  {raizQ} é = {Math.Round(resposta, 2)}");
            Console.WriteLine();
        }
       
        static void Potencia()
     
        {
   double n1, n2, resultado;

           
            
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.Write("Digite a base: ");
            
            n1 = double.Parse(Console.ReadLine());

 
            
            Console.Write("Digite o expoente: ");
   
            n2 = double.Parse(Console.ReadLine());

  
            
            Console.WriteLine();
     
            resultado = Math.Pow(n1,n2);

   
            
            Console.WriteLine($"A potencia de {n1} ^ {n2} é = {resultado}");
            Console.ResetColor () ;
            Console.WriteLine();
      
        }                                                                                       
                                                                                                        
        static void Extra()
        {
                    Console.Clear();

                    Console.WriteLine("Desenvolvedor chefe: Amyr Abdul Rahman");
                    Console.WriteLine("Instituição: Etec Adolpho berezin ");
                    Console.WriteLine("Materia: P.C 1");
                    Console.WriteLine("Profs: Hermogenes e Neri");
                    Console.WriteLine("Atividade de encerramento ");
                    Console.WriteLine("Obrigado por ser minha cobaia");
                    Console.WriteLine("Vejo voçês em Pc2");
        }
    }
}
