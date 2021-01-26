using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        private static object lis;

        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("Antalya");
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Count);// şehirler listesindeki elman sayısı

            MyList<string > sehirler2 = new MyList<string >();
            sehirler2.Add("Kars");
            sehirler2.Add("Gaziantep");
            Console.WriteLine(sehirler2.MyCount);

        }
    }

    class MyList<T>  /* <T> ile Mylist i Generic bir tip haline getirdik*/
    {
        T[] myArray;
        T[] myTempArray;
        public MyList()
        {
            myArray = new T[0];
        }
        public void Add(T item)
        {
            myTempArray = myArray;
            myArray = new T[myArray.Length+1];
            for (int i = 0; i < myTempArray.Length; i++)
            {
                myArray[i] = myTempArray[i];
            }
            myArray[myArray.Length - 1] = item;
        }

        public int MyCount
        {
            get { return myArray.Length; }
            
        }



    }
}
