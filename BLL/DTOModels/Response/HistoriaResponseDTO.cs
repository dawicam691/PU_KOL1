using BLL.DTOModels.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class HistoriaResponseDTO
    {
        public int? IdStudenta { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public int? IdGrupy { get; set; }
        [ForeignKey(nameof(IdGrupy))]
        public TYP_AKCJI_DTO TypAkcjiDTO { get; set; }
        public DateTime Data { get; set; }
    }
}
