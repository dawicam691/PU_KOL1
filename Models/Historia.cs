using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Historia
    {
        public int? Id { get; set; }
        public int? IdStudenta { get; set; }
        public string? Imie {  get; set; }
        public string? Nazwisko { get; set; }
        public int? IdGrupy { get; set; }
        [ForeignKey(nameof(IdGrupy))]
        public Grupa? Grupa { get; set; }
        public TYP_AKCJI TypAkcji { get; set; }
        public DateTime Data {  get; set; }
    }
}
