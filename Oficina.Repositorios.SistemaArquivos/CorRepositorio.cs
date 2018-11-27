using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        public List<Cor>Selecionar()
        {
            var cores = new List<Cor>();

            //para cada linha que esta dentro do arquivo de texto 
            foreach (var linha in File.ReadAllLines("Dados\\Cor.txt"))
            {
                //Cor cor = new Cor();
                var cor = new Cor();

                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
            }


            return cores;

        }
    }
}
