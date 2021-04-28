using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperSpaceSystem
{
    public class Fucions
    {
        public Position getVectorHyperSpace(int lat,int logi)
        {
            int[] aDividir = new int[6] { 13, 11, 7, 5, 3, 2 };
            int residuo = 0;
            int residuo2 = 0;

            foreach (int item in aDividir)
            {
                residuo = residuo + (lat % item);
                residuo2 = residuo2 + (logi % item);
            }
            Position pst = new Position();
            pst.lat = residuo;
            pst.Long = residuo2;
            return pst;
        }


        public mcmMcd getClassMcmMcd(int numero1, int numero2)
        {
            int mcm = getMCM(numero1, numero2);
            int mcd = getMCD(numero1,numero2);
            mcmMcd calculs = new mcmMcd();
            calculs.mcd = mcd;
            calculs.mcm = mcm;
            return calculs;
        }

        public int getMCM(int numero1, int numero2)
        {
            int mcm = 0, a, b;
            a = Math.Max(numero1, numero2);
            b = Math.Min(numero1, numero2);
            mcm = (a / getMCD(numero1, numero2)) * b;
            return mcm;
        }

        public int getMCD(int numero1, int numero2)
        {
            int mcd = 0, a, b;
            a = Math.Max(numero1, numero2);
            b = Math.Min(numero1, numero2);
            do
            {
                mcd = b;
                b = a % b;
                a = mcd;
            } while (b != 0);

            return mcd;
        }

        public class mcmMcd
        {
            public int mcm;
            public int mcd;

        }

        public class Position { 
           public int Long;
           public int lat;
        }
    }
}
