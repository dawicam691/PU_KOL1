using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALModels.Classes
{
    public class GrupaDAL
    {
        public string Nazwa { get; set; }
        public List<StudentDAL>? StudenciDAL { get; set; }
    }
}
