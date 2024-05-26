using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGosiTest
{
    public class CarPark
    {
        public int id { get; set; }
        public string Name { get; set; }
        [ForeignKey("CarParkId")]
        public List<Car> Cars { get; set; }
    }
}
