using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Grupa
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public List<Student>? Studenci { get; set; }
    }
}
