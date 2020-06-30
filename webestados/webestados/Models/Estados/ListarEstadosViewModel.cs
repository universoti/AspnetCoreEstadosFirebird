using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webestados.Models.Estados
{
    public class ListarEstadosViewModel
    {
        public List<EstadosViewModel> ListarEstadosPesq()
        {

            List<EstadosViewModel> Lista = new List<EstadosViewModel>()
        {
            new EstadosViewModel(){Sigla="SP",NomeEstado="SÃO PAULO",Aliquota=27 },
            new EstadosViewModel(){Sigla="MG",NomeEstado="MINAS GERAIS ",Aliquota=18 },
            new EstadosViewModel(){Sigla="MT",NomeEstado="MATO GROSSO",Aliquota=12 },
            new EstadosViewModel(){Sigla="RG",NomeEstado="RIO DE JANEIRO",Aliquota=12 }
        };


            return Lista;
        }
    }
}
