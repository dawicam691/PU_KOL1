using BLL.DTOModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class GrupaResponseDTO
    {
        public string Nazwa { get; set; }
        public List<StudentResponseDTO>? StudenciResponseDTO { get; set; }
    }
}
