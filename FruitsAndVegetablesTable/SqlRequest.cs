using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsAndVegetablesTable
{
    public class SqlRequest
    {
        public string Name { get; set; }
        public string Request { get; set; }


        public SqlRequest(string name, string sqlRequest)
        {
            Name = name;
            Request = sqlRequest;
        }
        

        public override string ToString()
        {
            return Name;
        }
    }
}
