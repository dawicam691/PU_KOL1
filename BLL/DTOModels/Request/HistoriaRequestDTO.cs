using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class HistoriaRequestDTO
    {
        public int? IdStudenta { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public int? IdGrupy { get; set; }
        public TYP_AKCJI_DTO TypAkcjiDTO { get; set; }
        public DateTime Data { get; set; }
    }
}
