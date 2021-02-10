using System;
using System.IO;
using System.Text;


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
            DateTime data2 = DateTime.Now;
            data = data.AddDays(100);
            data2 = data2.AddMonths(3);

            dynamic numerocaseswitch = 5;
            bool verdade = true; 
            switch (numerocaseswitch) // testando cases em c#
            {
                case 1: // Brincando com a logica
                    // Operadores logicos && <- And e || <- Or
                    if (verdade == true)
                    {
                        Mensagem("Dia depois de 100 dias: " + data);
                        Mensagem("Daqui a 3 meses será: " + data2);
                        Console.WriteLine(Class1.classe); // Aprendendo sobre objetos e classes.
                        Console.ReadLine();
                    }
                    else
                    {
                        Mensagem(tipodinamico);
                        Mensagem("Hello World " + meutexto);
                        Mensagem("Meu Nome é Leonardo");
                        Mensagem(numero + numerodecimal);
                        Mensagem(minhaletra);
                        Console.ReadLine();
                        tipodinamico = "mudei o tipo";
                        Mensagem(tipodinamico);
                        numerodecimal = 13.56f;
                        Mensagem("iuu");
                        Mensagem(numerodecimal);
                        Mensagem(divisao);
                        Console.ReadLine();
                    }
                    break;
                case 2: // Escrevendo arquivos
                    StreamWriter arquivo = new StreamWriter("nomes.Txt");
                    int i = 0;
                    while (i < 5)
                    {
                        Console.WriteLine("Digite um nome");
                        string nome = Console.ReadLine();
                        arquivo.WriteLine(nome);
                        i++;
                    }
                    arquivo.Close();
                    Console.WriteLine("Arquivo Gerado");
                    Console.ReadLine();
                    break;
                case 3: // Lendo arquivos e armazeando em arrays
                    StreamReader leitor = new StreamReader("nomes.txt", Encoding.Default); // Enconding é bom para ler palavras com acento
                    string[] lido = leitor.ReadToEnd().Split('\n');

                    foreach (string nome in lido)
                    {
                        Console.WriteLine(nome);
                    }
                    Mensagem("Arquivo Lido");
                    Console.ReadLine();           
                    break;
                case 4: // Testando Funções
                    Mensagem("olá");
                    Mensagem("Tudo bom?");
                    int result = Somar(4, 5);
                    Mensagem(result);
                    Console.ReadLine();
                    break;
                case 5: // testando continue
                    for (int i2 = 1; i2 <= 10; i2++)
                    {
                        if (i2 < 9)
                        {
                            continue;
                        }
                        Console.WriteLine(i2);
                    }

                    // Keep the console open in debug mode.
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
            }
            
        }
        static void Mensagem(dynamic msg)
        {
            Console.WriteLine(msg);
        }
        static int Somar(int i, int j)
        {
            int soma = i + j;
            return soma;
        }
    }
}
