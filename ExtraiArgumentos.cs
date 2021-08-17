using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_string_exp_regulares
{
    public class ExtraiArgumentos
    {
        private string _url;
        private readonly string _argumentos;
        public string URL { get; }
        public ExtraiArgumentos(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL Não pode ser nula ou vazia!");
            }

            int indice = url.IndexOf('?');
            _argumentos = url.Substring(indice+1);
            URL = url;
        }

        public string GetValor(string parametro)
        {
            parametro = parametro.ToUpper();
            string argumentoCaixaAlta = _argumentos.ToUpper();

            string termo = parametro + "=";
            int indice = argumentoCaixaAlta.IndexOf(termo);

            return argumentoCaixaAlta.Substring(indice+termo.Length);
        }
    }
}
