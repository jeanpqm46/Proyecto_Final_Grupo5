using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Class1
    {
        public int i = 0;
        public int i2 = 0;
        public string[] Postres = new string[5];


        public void AgregarPostre(string nompostre)
        {
            
                for (int i = 0; i < Postres.Length; i++)
                {
                    if (Postres[i] == null)
                    {
                    Postres[i] = nompostre;
                        return;
                    }
                }
                i2 = 6;
            

        }

       
           





       

    }
}
