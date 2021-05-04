using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperSpaceSystem
{
    public class Fucions
    {
        int longi = 0, lat = 0, newlat = 0, newlong=0;
        public class PositionTable
        {
            public int LONG;
            public int LAT;
            public string codiRoute;
            public bool major300;
        }
        //num1 latitud   num2 longitud
        public PositionTable getRoute(int num1,int num2)
        {
            bool mayor300=false;
            PositionTable pst = new PositionTable();
            int contador = 0;
            int cordenadasLat = 0;
            int cordenadasLong = 0;
            string[] postition = new string[6] {"A","B","C","D","E","F"};
            List<int> lst = new List<int>();
            getVectorHyperSpace(num1, num2);
            newlat = getMCM(lat, longi );
            newlong = getMCD(lat, longi);
            lst = getList(newlat, newlong);

            foreach (int item in lst)
            {
                if (contador<=3)
                {
                    cordenadasLat += item;
                    mayor300 = true;
                }
                else
                {
                    cordenadasLong += item;
                }
                contador++;
            }
            cordenadasLat  =cordenadasLat%6;
            cordenadasLong = (cordenadasLong % 7) + 1;

            pst.LAT = cordenadasLat;
            pst.LONG = cordenadasLong;
            pst.codiRoute = postition[cordenadasLat] + cordenadasLong;
            pst.major300 = mayor300;


            return pst;
        }

        private List<int> getList(int num1, int num2)
        {
            List<int> lstoperation = new List<int>();

            lstoperation.Add(num1+num2);
            lstoperation.Add(num1 - num2);
            lstoperation.Add(num2 - num1);
            lstoperation.Add(num1 * num2);
            lstoperation.Add((int)(num1 / num2));
            lstoperation.Add((int)(num2 / num1));

            if ((num1*num2)>300)
            {
                lstoperation.Clear();
            }
            return lstoperation;
        }

        public void getVectorHyperSpace(int num1,int num2 )
        {
            int[] aDividir = new int[6] { 13, 11, 7, 5, 3, 2 };
            int residuoLong = 0;
            int residuoLat = 0;

            foreach (int item in aDividir)
            {
                residuoLong = residuoLong + (num2 % item);
                residuoLat = residuoLat + (num1 % item);
            }
            longi = residuoLong;
            lat = residuoLat;
        }

        public int getMCM(int numero1, int numero2)
        {//Logitud
            int mcm=0,  a, b;
            a = Math.Max(numero1, numero2);
            b = Math.Min(numero1, numero2);
            mcm = (a / getMCD(numero1, numero2)) * b;
            return mcm;
        }

        public int  getMCD(int numero1, int numero2)
        {//Latitud
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

       
    }
}
