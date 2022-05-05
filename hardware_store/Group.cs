using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    class Group
    {
        public List<ProductCard> cards { get; set; }
        public string name { get; set; }
        public int id { get; set; }

        public Group() { }
        public Group(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
}
