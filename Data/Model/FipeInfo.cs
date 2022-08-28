using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class FipeInfo : BaseModel
    {
        public string price { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int modelYear { get; set; }
        public string fuel { get; set; }
        public string codeFipe { get; set; }
        public string referenceMonth { get; set; }
        public int vehicleType { get; set; }
        public string fuelAcronym { get; set; }
    }
}
