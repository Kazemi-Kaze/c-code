using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nummer = new List<int>();
            foreach (medarbejder item in liste)
            {

               // var jj = item.tlf.OrderByDescending(x => x);
                nummer.Add(item.tlf[0]);
                nummer.Add(item.tlf[1]);

            }

            //add metodes with out inhareting the class
           var hp = nummer.OrderBy(x => x);

            foreach (int item in hp)
            {
                Console.WriteLine(item);
            }


            //linq selece statment
            var qr = 
                from item 
                in nummer 
                where item == 149675 
                select item;
            foreach (int item in qr)
            {
                Console.WriteLine(item);
            }


            //read up on func

            Console.Read();






        }


        public class medarbejder
        {
            public string fornavn;
            public string efternavn;
            public int id;
            public List<int> tlf;
        }

        static List<medarbejder> liste = new List<medarbejder> 
        {
            new medarbejder {fornavn = "mark",efternavn = " smith",id=0,tlf = new List<int>{123456,135790}},
             new medarbejder {fornavn = "hans",efternavn = " larsen",id=0,tlf = new List<int>{852852,852369}},
              new medarbejder {fornavn = "jens",efternavn = " jensen",id=0,tlf = new List<int>{741147,789123}},
               new medarbejder {fornavn = "peter",efternavn = " petersen",id=0,tlf = new List<int>{951159,755357}},
                new medarbejder {fornavn = "kim",efternavn = " kimsen",id=0,tlf = new List<int>{751595,753595}},
                 new medarbejder {fornavn = "lasse",efternavn = " las",id=0,tlf = new List<int>{149675,358575}}
        };


    }

}
