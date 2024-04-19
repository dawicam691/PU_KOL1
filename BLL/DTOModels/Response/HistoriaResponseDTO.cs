using BLL.DTOModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class HistoriaResponseDTO
    {
        public StudentResponseDTO? StudentResponseDTO { get; set; }
        public GrupaResponseDTO? GrupaResponseDTO { get; set; }
        public TYP_AKCJI_DTO TypAkcjiDTO { get; set; }
        public DateTime Data { get; set; }
    }
}
