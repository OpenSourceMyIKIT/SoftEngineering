using System.Collections.Generic;

namespace Model
{
    public class Detail
    {
        private List<Product> products = new List<Product>();

        private int serialNumber;
        private string name;

        public int SerialNumber { get; set; }
        public string Name { get; set; }

        public Detail(int serialNumber, string name)
        {
            this.serialNumber = serialNumber;
            this.name = name;
        }
    }
}