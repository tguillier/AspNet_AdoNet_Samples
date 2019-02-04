using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {
        private IPossedeTraitement maClasse2;

        public Class1(IPossedeTraitement maClasse2)
        {
            this.maClasse2 = maClasse2;
        }

        public string Traitement()
        {
            return this.maClasse2.Traitement();
        }
    }
}
