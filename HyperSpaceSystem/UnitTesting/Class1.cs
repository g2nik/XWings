using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace UnitTesting
{
    [TestFixture]
    public class Class1
    {
        HyperSpaceSystem.Fucions fcn = new HyperSpaceSystem.Fucions();

        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(9, 25, ExpectedResult = 225)]
        [TestCase(7, 14, ExpectedResult = 14)]
        public int getMCM_Equal(int numero1, int numero2)
        {
            var numeroMCM = fcn.getMCM(numero1, numero2);
            return numeroMCM;
        }

        //Funcion prova si la funcion de getMCD es correcta cridant comparant el valor retornat
        //y el comprara amb la funcio creada dins del programa
        [TestCase(0, 1)]
        [TestCase(9, 0)]
        [TestCase(0, 0)]
        public void getMCM_DivideZeroExeotion(int numero1, int numero2)
        {
            Assert.Throws<DivideByZeroException>(() => fcn.getMCM(numero1, numero2));
        }

        //La funcio de getCalculs retorna una lista sense dades degut a que en la multiplicacio dona un resultat mayor a 300
        [TestCase(9, 39)]
        [TestCase(9, 35)]
        [TestCase(8, 38)]
        public void getListEmpycontent_EmptyList(int numero1, int numero2)
        {
            List<int> lista = new List<int>();
            lista = fcn.getList(numero1, numero2);
            
            Assert.IsEmpty(lista);
        }

        //La funcion de setCalculs retorna una llista amb dades degut a que cap numero multiplicat per el altre supera el numero 300 
        [TestCase(8, 24)]
        [TestCase(5, 32)]
        [TestCase(4, 12)]
        public void getListWithData_NotEmpty(int numero1, int numero2)
        {
            List<int> lista = new List<int>();            
            lista = fcn.getList(numero1, numero2);
         
            Assert.IsNotEmpty(lista);
        }

        [TestCase(8, 24)]
        public void getListWithArrayData_Equivalent(int numero1, int numero2)
        {
            List<int> lista = new List<int>();
            lista = fcn.getList(numero1, numero2);

            Assert.IsNotEmpty(lista);
            Assert.That(lista.Count(), Is.EqualTo(6));
            Assert.That(lista, Is.EquivalentTo(new[] { 32, -16, 16, 192, 0, 3 }));
        }

        [TestCase(8982345, 672311)]
        public void getVectorHyperSpace_Equivalent(int num1, int num2)
        {
            int[] lista = new int[2];
            lista = fcn.getVectorHyperSpace(num1,num2);

            Assert.That(lista, Is.EquivalentTo(new[] { 12, 19 }));
        }

        [TestCase(898234115, 6725311)]
        [TestCase(898232345, 6723311)]
        [TestCase(891823445, 6725311)]
        public void getVectorHyperSpace_NotEquivalent(int num1, int num2)
        {
            int[] lista = new int[2];
            lista = fcn.getVectorHyperSpace(num1, num2);

            Assert.AreNotEqual(lista, new[] { 15, 5 });
        }
    }
}
