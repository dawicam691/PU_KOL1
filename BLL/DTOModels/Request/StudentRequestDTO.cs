using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class StudentRequestDTO
    {
        /// <summary>
        /// Id tylko do aktualizacji (update) rekordu
        /// </summary>
        public int? Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int? IdGrupy { get; set; }
    }
}
