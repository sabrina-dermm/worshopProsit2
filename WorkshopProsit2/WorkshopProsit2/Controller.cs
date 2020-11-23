using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopProsit2
{
    class Controller : IController
    {
        private Model model;
        
       private View view;
        
        public Controller()
        {
            
            view = new View();
            model = new Model();
            view.SetController(this);
            view.returnMot();
        }
        
        public void methode()
        {
            model.mot = view.mot;
            view.motConvertitEnMaj = model.ConvertirEnMaj();
            view.afficherLeMot();
        }
        
    }
}
