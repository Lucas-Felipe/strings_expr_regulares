using System;
using System.Text.RegularExpressions;

namespace Projeto_string_exp_regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://exemplo.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            int interrog = url.IndexOf('?')+1;

            url = url.Substring(interrog);
            string testando1 = "teste";
            int teste2 = 18;
            ExtraiArgumentos a = new ExtraiArgumentos(url);
              
            //Console.WriteLine(a.GetValor("moedaOrigem").Remove(a.GetValor("moedaOrigem").IndexOf('&')));

            string teste = "meu nome é lucas me lige no telefone 9629-9987";
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            Console.WriteLine(Regex.Match(teste,padrao).Value);

            Console.WriteLine($"url: {a.GetValor("moedaOrigem")}, {testando1}, {teste2*6+1}");


        }
    }
}
