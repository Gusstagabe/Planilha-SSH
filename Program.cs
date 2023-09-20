using System.ComponentModel;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        static void pro1(){
             double valorPresente = 1000;
            double taxaJuros = 0.053;
            int n = 10;
            Console.WriteLine("O valor do rendimento é:");

            double rendimento = valorPresente*(Math.Pow((1+taxaJuros),n));
            Console.WriteLine($"O rendimento de um investimento é:{rendimento:C}");

        }
        pro1();
        Console.WriteLine("-----------");

        static void pro2(){
            double valorPresente = 3800;
            double taxaJuros = 0.0125;
            double n = 0;
            Console.WriteLine("O valor do rendimento é:");
            while(n<6){
                n++;
            double rendimento = valorPresente*(Math.Pow((1+taxaJuros),n));
            Console.WriteLine($"No mês {n} o valor é:{rendimento:C}");
            }


        }
        pro2();
        Console.WriteLine("------------");

        static void pro3(){
            Console.WriteLine("Informe o valor presente: ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a taxa de juros: ");
            double taxaJuros =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o periodo em anos:");
            double periodo = Convert.ToDouble(Console.ReadLine());

            taxaJuros = taxaJuros /100;

            double rendimento = valorPresente*(Math.Pow((1+taxaJuros),periodo));

            Console.WriteLine($"O rendimento é: {rendimento:C}");
        }
        pro3();
        Console.WriteLine("-----------");

        static void pro4(){
            Console.WriteLine("Digite o valor presente: ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros:");
            double taxaJuros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os meses");
            double meses = Convert.ToDouble(Console.ReadLine());

            
            double[] conta = new double[12];
            Console.WriteLine("Digite o valor que será resgatado no 5 mês");
            double sub = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= meses; i++)
            {
                conta[i] = valorPresente * Math.Pow(1+taxaJuros / 100, i);
                Console.WriteLine($"O valor final no mes {i} é {conta[i]:C}");
            }
            Console.WriteLine($"O saldo apos o resgate do 5 mes é: {conta[5] - sub:C}");
        }
        pro4();
        static void pro5(){
            double p, i, f;
            int n;
            int cont = 1;
            n =6;
            double[] v = new double[12];
            i = 0.0125;
            f= 7390.61;
            while(cont <=6){
                v[cont] = Math.Pow(1+i / 100, i);
                p = f / v[cont];
                cont++;
                Console.WriteLine($"{p:C}");
            }

        }
        pro5();
    }

}