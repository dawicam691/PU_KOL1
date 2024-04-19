using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Historia
    {
        public int Id { get; set; }
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }
        public int IdGrupy { get; set; }
        public TYP_AKCJI TypAkcji { get; set; }
        public DateTime Data {  get; set; }
    }
}
