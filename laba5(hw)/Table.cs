using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Table
    {
        public int Number;
        public string Color;
        public Employee Site1;
        public Employee Site2;
        public Employee Site3;
        public Employee Site4;
        private bool Engaged;
        private bool EngagedCovid()
        { int col = 0;
            if (Site1 != null) col++;
            if (Site2 != null) col++;
            if (Site3 != null) col++;
            if (Site4 != null) col++;
            if (col >= 3) return true;
            else return false;
        }
        public Table(int Number, string Color)
        {
            this.Number = Number;
            this.Color = Color;
        }
        public  bool PutEmployee(Employee em)
        {
            if (Site1 == null) {Site1=em;return true;}
            if (Site2 == null) {Site2=em;return true;}
            if (Site3 == null) {Site3=em;return true;}
            if (Site4 == null) {Site4=em;return true;}
            return false;
        }
        public bool FindFamiliar(Employee em)
        {
        //    if (Site1 != null & Familiar(Site1,em) & em.Stupidity == 0) return true;
        //    if (Site2 != null & Familiar(Site2,em) & em.Stupidity == 0) return true;
        //    if (Site3 != null & Familiar(Site3,em) & em.Stupidity == 0) return true;
        //    if (Site4 != null & Familiar(Site4,em) & em.Stupidity == 0) return true;

        //    if (Site1 != null & !Familiar(Site1, em) & em.Stupidity == 1) return true;
        //    if (Site2 != null & !Familiar(Site2, em) & em.Stupidity == 1) return true;
        //    if (Site3 != null & !Familiar(Site3, em) & em.Stupidity == 1) return true;
        //    if (Site4 != null & !Familiar(Site4, em) & em.Stupidity == 1) return true;
            return false;
        }

    }
}
