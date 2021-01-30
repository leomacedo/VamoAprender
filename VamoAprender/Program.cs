using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace VamoAprender
{
    class Program
    {

        /* 
            Comandos legais:
            Auto-identar em c# Ctrl K,F
            Comentar a linha: Ctrl K,C Descomentar a linha: Ctrl K,U
        */

        static void Main(string[] args)
        {
            string meutexto = "oie"; // aspas duplas para string
            char minhaletra = 'i'; // aspas simples para char
            int numero = 4;
            float numerodecimal = 12.9f;
            dynamic tipodinamico = 12; // dynamic é uma variavel do tipo que pode ser qualquer coisa... porem nao é muito usada.
            float divisao = 5f / 2; // Atentar-se a divisão. Se você quer o resultado correto sempre coloque uma tipagem que aceita numeros decimais.
            DateTime data = new DateTime(2010, 1, 25); // Datas em c#
            data = data.AddDays(100);

            dynamic numerocaseswitch = 2;
            bool verdade = true; 
            switch (numerocaseswitch) // testando cases em c#
            {
                case 1:
                    if (verdade == true)
                    {
                        Console.Write("Dia depois de 100 dias: ");
                        Console.WriteLine(data);
                        Console.WriteLine(Class1.classe); // Aprendendo sobre objetos e classes.
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(tipodinamico);
                        Console.WriteLine("Hello World " + meutexto);
                        Console.WriteLine("Meu Nome é Leonardo");
                        Console.WriteLine(numero + numerodecimal);
                        Console.WriteLine(minhaletra);
                        Console.ReadLine();
                        tipodinamico = "mudei o tipo";
                        Console.WriteLine(tipodinamico);
                        numerodecimal = 13.56f;
                        Console.WriteLine("iuu");
                        Console.WriteLine(numerodecimal);
                        Console.WriteLine(divisao);
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Digite um texto");
                    string texto = Console.ReadLine();

                    StreamWriter arquivo = new StreamWriter("nomes.Txt");
                    arquivo.WriteLine(texto);
                    arquivo.Close();
                    Console.WriteLine("Arquivo Gerado");
                    Console.ReadKey();

                    StreamReader leitor = new StreamReader("nomes.txt", Encoding.Default); // Enconding é bom para ler palavras com acento
                    string lido = leitor.ReadToEnd();

                    Console.WriteLine(lido);
                    Console.ReadKey();

                  
                    break;
            }

        }
    }
}
