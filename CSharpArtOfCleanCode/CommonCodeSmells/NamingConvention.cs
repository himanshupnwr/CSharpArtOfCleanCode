using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArtOfCleanCode.CommonCodeSmells
{
    public class NamingConvention
    {
        //Dotnet has two type of naming conventions
        //Pascal case - where capital letter is the first letter used for class name ans its properties
        //Camel case - where first letter is _ or small case used for private fields

        //Example
        private int _id;
        public string Name { get; set; }
        public void Charge(int amount)
        {
            var tax = 0;
        }
    }
}
