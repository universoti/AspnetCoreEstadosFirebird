using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webestados.Controllers.Estados;

namespace webestados.Models.Estados
{
    public class EstadosViewModel
    {

        public string Sigla { get; set; }
        public string NomeEstado { get; set; }
        public decimal Aliquota { get; set; }
    }

    
}
