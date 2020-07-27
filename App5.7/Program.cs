using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace App5._7
{
    class Program
    {

        static void Main(string[] args)
        {

            Seletor slc = new Seletor();

            do
            {
                

                slc.vitrine();

                while(slc.GetCondicao())
                {
                    slc.tratador();
                }
               

                ControladorDeExercicio contr = new ControladorDeExercicio(slc.GetLetra());

                if (slc.GetLetra() != "ok")
                {
                    while (contr.GetTratador())
                        contr.ChamarMetodo();  
                }

            }
            while (slc.GetLetra() != "ok");

        }
    }
}
