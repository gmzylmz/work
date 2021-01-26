using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int,string>();
            Ogrenci.Add(100,"Ahmet Yılmaz");
            Ogrenci.Add(101,"Mine Sayar");
            Ogrenci.Add(102,"Aslı Şahin");
            Ogrenci.Add(103,"Emre Güneş");


            foreach (KeyValuePair<int, string> veri in Ogrenci)
                Console.WriteLine("Numara:{0} - İsim:{1}", veri.Key, veri.Value);


        }
    }
}
