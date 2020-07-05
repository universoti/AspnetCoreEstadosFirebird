using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace webestados.ViewModel
{
    public class LEstadosViewModel
    {
        public string SIGLA { get; set; }
        public string DESCRICAO { get; set; }
        public decimal VL_ALIQ_UF { get; set; }

        public static List<LEstadosViewModel> ListarTabela(DataTable dt) 
        {
            List<LEstadosViewModel> lista = new List<LEstadosViewModel>();
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LEstadosViewModel estados = new LEstadosViewModel()
                {
                    SIGLA = dt.Rows[i]["SIGLA"].ToString(),
                    DESCRICAO = dt.Rows[i]["DESCRICAO"].ToString(),
                    VL_ALIQ_UF = decimal.Parse(dt.Rows[i]["VL_ALIQ_UF"].ToString()),
                    
                };
                lista.Add(estados);
            }

            return lista;
        }
    }
}
