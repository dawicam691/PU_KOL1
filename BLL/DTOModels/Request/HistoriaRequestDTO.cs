using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class HistoriaRequestDTO
    {
        /// <summary>
        /// Id tylko do aktualizacji (update) rekordu
        /// </summary>
        public int? Id { get; set; }
        public StudentRequestDTO? StudentRequestDTO { get; set; }
        public GrupaRequestDTO? GrupaRequestDTO { get; set; }
        public TYP_AKCJI_DTO TypAkcjiDTO { get; set; }
        public DateTime Data { get; set; }
    }
}
