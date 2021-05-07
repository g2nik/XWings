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
        bool major300 = false;
        public class PositionTable
        {
            public int LONG;
            public int LAT;
            public string codiRoute;
            public bool major300;
            public string namePlanetDes;
        }
        //num1 latitud   num2 longitud
        public PositionTable getRoute(int num1,int num2)
        {
            PositionTable pst = new PositionTable();
            int contador = 0;
            int cordenadasLat = 0;
            int cordenadasLong = 0;
            string[] postition = new string[6] {"A","B","C","D","E","F"};
            List<int> lst = new List<int>();
            int[] latLong = new int[2];
            
           latLong=  getVectorHyperSpace(num1, num2);
            newlat = getMCM(latLong[1], latLong[0]);
            newlong = getMCD(latLong[1], latLong[0]);
            lst = getList(newlat, newlong);

            foreach (int item in lst)
            {
                if (contador<=3)
                {
                    cordenadasLat += item;
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
            pst.major300 = major300;
            return pst;
        }

        public List<int> getList(int num1, int num2)
        {
            major300 = false;
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
                major300 = true;
            }
            return lstoperation;
        }

        public int[] getVectorHyperSpace(int num1,int num2 )
        {
            int[] aDividir = new int[6] { 13, 11, 7, 5, 3, 2 };
            int[] latLon = new int[2];

            int residuoLong = 0;
            int residuoLat = 0;

            foreach (int item in aDividir)
            {
                residuoLong = residuoLong + (num2 % item);
                residuoLat = residuoLat + (num1 % item);
            }

            latLon[0]= residuoLong;
            latLon[1] = residuoLat;
            return latLon;
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
