using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopProsit2
{
    class Model
    {
        public string mot { get; set; }

        public Model()
        {
            mot = "";
        }
        public String ConvertirEnMaj()
        {
            String motEnMaj = mot.ToUpper();
            return motEnMaj;
        }
    }
}
