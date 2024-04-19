using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.DALModels.Classes
{
    public class StudentDAL
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public GrupaDAL? GrupaDAL { get; set; }
    }
}
