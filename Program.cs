using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ConcatenarPalavras();
            verificarAulaEtec();
            CalcularMedia();
            CalcularTabuada();

            DetalharData();
            CalcularDescontoINSS();
        }

             public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine("");

            Console.WriteLine("Quanto custa um dolár em reais? ");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dddd}, o dolár está custando {1:c2} ", DateTime.Now, valorDolarReais);
            Console.WriteLine(frase2);

            Console.WriteLine(" ");
            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho.ToUpper());
        }
        
        public static void verificarAulaEtec()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios.");
            
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec!");
            }
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A media é {media}");

            if(media >= 7)
                Console.WriteLine("Aprovado");
            else if(media < 7 && media >= 4)
                Console.WriteLine("Recuperação");
            else 
                Console.WriteLine("Reprovado");
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calcular");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while(contador <= 10)
            {
                string mensagem = string.Format("{0} x {1} = {2}", tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            string frase01 = string.Format("{0:dd}, {0:dddd} de {0:MMMM} de {0:yyyy}", data);
            Console.WriteLine(frase01);

            if(data.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("Horário {0:HH:mm}", DateTime.Now);
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite seu salário");
            decimal salario = decimal.Parse(Console.ReadLine());
                
            //*o “M” é uma maneira de deixar claro que estamos lidando com valores do tipo decimal. Se você não especificar o “M”, o compilador pode interpretar os números de forma diferente.
            if( salario > 3641.03M)
                {decimal desconto = salario * 0.14M ;
                Console.WriteLine($" O desconto do INSS é :{desconto}");

                decimal salarionovo = (salario - desconto);
                Console.WriteLine($" Salário com desconto: {salarionovo}");
                }

            else if(salario <= 3641.03M && salario > 2427.35M)
                {decimal desconto = salario * 0.12M ;
                Console.WriteLine($" O desconto do INSS é :{desconto}");

                decimal salarionovo = (salario - desconto);
                Console.WriteLine($" Salário com desconto: {salarionovo}");
                } 

            else if(salario <= 2427.35M && salario > 1212.00M)       
                {decimal desconto = salario * 0.09M ;
                Console.WriteLine($" O desconto do INSS é :{desconto}");

                decimal salarionovo = (salario - desconto);
                Console.WriteLine($" Salário com desconto: {salarionovo}");
                }

            else
                {decimal desconto = salario * 0.075M ;
                Console.WriteLine($" O desconto do INSS é :{desconto}");

                decimal salarionovo = (salario - desconto);
                Console.WriteLine($" Salário com desconto: {salarionovo}");
                }    


        }
    }
}