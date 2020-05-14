using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace exercicioT1P
{
    class Program
    {
        static void Main(string[] args)
        {
            bool XMenu = true;
            while (XMenu)
            {
                int Menu = Views.Principal();
                switch (Menu)
                {
                    case 1:
                        View.Tela2();
                        break;
                    case 2:
                        View.Tela3();
                        break;
                    case 3:
                        View.Tela4();
                        break;
                    case 4:
                        View.Tela5();
                        break;
                    case 5:
  //                      View.Tela6();
                        break;
                    case 6:
                        break;
                }
            }

        }
    }
}
