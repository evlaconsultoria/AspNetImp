using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        [TestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void SelecionarTest(int marcaId)
        {

            var reposiotior = new ModeloRepositorio();

            var modelos = reposiotior.SelecionarPorMarca(marcaId);

            foreach (var modelo in modelos)
            {
                Console.WriteLine($"{modelo.Id}: {modelo.Nome} ({modelo.Marca.Nome})");
            }


        }

        [TestMethod()]
        [DataRow(1)]
        public void SelecionarTest1(int id)
        {
            Assert.IsTrue(new ModeloRepositorio().Selecionar(id).Nome=="Fox");
        }
    }
}