using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopProsit2
{
    class View
    {
        public String motConvertitEnMaj { get; set; }
        public String mot { get; set; }
        public IController controller { get; set; }
       
        public View()
        {
            motConvertitEnMaj = "";
            mot = "";
        }

        //lier le view avec controller 
        public void SetController(IController cont)
        {
            controller = cont;
        }
       
        public void returnMot()
        {
            bool verificationMot = false;
            
            Console.WriteLine("Veuillez saisir le mot ");
            while (verificationMot != true)
            {
                mot = Console.ReadLine();

                verificationMot = verifierMot(mot);
            }
           

        }
        public bool verifierMot(String mot)
        {
            bool valider = false;
            if (mot.Length < 1 || mot.Length >= 8)
            {
                Console.WriteLine("votre mot ne respecte pas la taille de mot il faut qu'il soit inférieure ou égale à 8 et supérieure que 1");
                
            }
            else
            {
                controller.methode();
                valider = true;
            }
            return valider;

        }
        public void afficherLeMot()
        {
            Console.WriteLine("votre mot en majuscule est " + motConvertitEnMaj );
        }
      
    }
}
