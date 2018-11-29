using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class VeiculoRepositorio
    {
        private readonly string caminhoArquivo;
        private XDocument arquivoXml;

        public VeiculoRepositorio()
        {
            caminhoArquivo= Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            ConfigurationManager.AppSettings["caminhoArquivoVeiculo"]);
        }

        public void Inserir(Veiculo veiculo)
        {
            arquivoXml = XDocument.Load(caminhoArquivo);

            var registro = new StringWriter();

            new XmlSerializer(typeof(Veiculo)).Serialize(registro,veiculo);
            arquivoXml.Root.Add(XElement.Parse(registro.ToString()));

            arquivoXml.Save(caminhoArquivo);

        }
    }
}
