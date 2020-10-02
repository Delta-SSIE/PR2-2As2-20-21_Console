using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_02_vsechna_suda
{
    class SudaCisla
    {
        public bool VsechnaSuda(int[] cisla)
        {
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] % 2 != 0)
                    return false;
            }
            return true;
        }

        public bool VsechnaSuda2(int[] cisla)
        {
            foreach (int cislo in cisla)
            {
                if (cislo % 2 != 0)
                    return false;
            }
            return true;
        }

        public bool VsechnaSuda3(int[] cisla)
        {
            return cisla.Where(x => x % 2 != 0).Count() == 0;
        }

        public bool VsechnaSuda4(int[] cisla)
        {
            return cisla.Aggregate(true, (bool acc, int x) => acc && x % 2 == 0);
        }
    }
}
