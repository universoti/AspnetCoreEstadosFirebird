using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webestados.Data.Banco;
using webestados.Data.DAL;
using webestados.Models.Estados;
using webestados.ViewModel;

namespace webestados.Controllers.Estados
{
    public class EstadosController : Controller
    {
        public IActionResult Index()
        {
            DAL CONNECTAR = new DAL();
            var dt = CONNECTAR.RetDataTable("select * from UF");
            LEstadosViewModel estados = new LEstadosViewModel();
            List<LEstadosViewModel> Listar_estados = estados.ListarTabela(dt);
            ViewBag.Estados = Listar_estados;
            return View();
        }


        public IActionResult EstadoPesquisado(string id)
        {           
            EstadosViewModel selecionado = new EstadosViewModel();
            selecionado = new ListarEstadosViewModel().ListarEstadosPesq().Where(c => c.Sigla == id).FirstOrDefault();

            ViewBag.Sigla = selecionado.Sigla;
            ViewBag.Descricao = selecionado.NomeEstado;
            ViewBag.Aliquota = selecionado.Aliquota;
            
            return View();
        }


        public IActionResult ListagemEstados()
        {
            Banco conexao = new Banco();
            List<LEstadosViewModel> listaEstados = new List<LEstadosViewModel>();
            if (conexao.bconexao)
            {
                var dt=conexao.RetornoTabela("select * from uf");
                LEstadosViewModel tratarEstados = new LEstadosViewModel();
                listaEstados = tratarEstados.ListarTabela(dt);
                
            }

            ViewBag.Estados = listaEstados;
            return View();
        }
    }
}