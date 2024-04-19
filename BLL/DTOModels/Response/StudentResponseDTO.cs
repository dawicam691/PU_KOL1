using BLL.DTOModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class StudentResponseDTO
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public GrupaRequestDTO? Grupa { get; set; }
    }
}
