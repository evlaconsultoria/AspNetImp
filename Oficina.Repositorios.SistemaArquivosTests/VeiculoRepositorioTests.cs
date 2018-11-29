using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Ano = 2014;
            veiculo.Placa = "EBS0795";
            veiculo.Cambio = Cambio.Automatico;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Observacao = "Observacao";

            veiculo.Cor = new CorRepositorio().Selecionar(1);
            veiculo.Modelo = new ModeloRepositorio().Selecionar(1);
                                 
            

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}