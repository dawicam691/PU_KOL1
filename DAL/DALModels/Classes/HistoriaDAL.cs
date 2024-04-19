using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DALModels.Enums;

namespace DAL.DALModels.Classes
{
    public class HistoriaDAL
    {
        public StudentDAL? StudentDAL { get; set; }
        public GrupaDAL? GrupaDAL { get; set; }
        public TYP_AKCJI_DAL TypAkcjiDAL { get; set; }
        public DateTime Data { get; set; }
    }
}
