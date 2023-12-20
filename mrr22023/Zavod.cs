using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mrr22023
{
    public class Zavod
    {
        
        public int Id { get; set; }
        public int Number {  get; set; }
        public string Position { get; set; }
        public int? Expirience { get; set; }
        public double Salary { get; set; }
        public string Surname { get; set; }
    }
}
