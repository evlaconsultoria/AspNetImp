﻿using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {
        private readonly MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        private readonly ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        private readonly CorRepositorio corRepositorio = new CorRepositorio();
        private readonly VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();

        public VeiculoAplicacao()
        {
            PopularControles();
        }

        public List<Marca> Marcas { get; private set;}
        public List<Cor> Cores { get; private set; }
        public List<Combustivel> Combustiveis { get; private set; }
        public List<Cambio> Cambios { get; private set; }

        public string MarcaSelecionada { get; set; }
        public List<Modelo> Modelos { get; private set; } = new List<Modelo>();

        private void PopularControles()
        {
            Marcas = marcaRepositorio.Selecionar();
            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"];

            if (!string.IsNullOrEmpty(MarcaSelecionada))
            {
                Modelos = modeloRepositorio.SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));
            }

            Cores = corRepositorio.Selecionar();

            Combustiveis = Enum.GetValues(typeof(Combustivel)).Cast <Combustivel>().ToList();
            Cambios = Enum.GetValues(typeof(Cambio)).Cast<Cambio>().ToList();


        }
    }
}
