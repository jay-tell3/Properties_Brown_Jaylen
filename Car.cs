using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Brown_Jaylen
{
    internal class Car
    {
        //makes a string varable
        private string model;
        //Makes a propertie for the model
        public string Model { get { return model; } set { model = value; } }
        //makes an automatice propertie for the make
        public string Make { get; set; }

    }
}
