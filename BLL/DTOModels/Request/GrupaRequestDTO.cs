using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class GrupaRequestDTO
    {
        /// <summary>
        /// Id tylko do aktualizacji (update) rekordu
        /// </summary>
        public int? Id { get; set; }
        public string Nazwa { get; set; }
        public List<StudentRequestDTO>? StudenciRequestDTO { get; set; }
    }
}
