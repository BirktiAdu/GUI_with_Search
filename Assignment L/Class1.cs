using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_L
{
    internal class Class1
    {
        static List<Class1> cl = new List<Class1>();
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }
        public string phoneNo { get; set; }
        public string email { get; set; }
        public string gender { get; set; }

        public void save()
        {
            cl.Add(this);
        }

        public List<Class1> GetProduct()
        {
            return cl;
        }

        public static Class1 findOne(string name)
        {
            return cl.Find(cl => cl.fname.ToLower() == name.ToLower());

        }
    }
}
