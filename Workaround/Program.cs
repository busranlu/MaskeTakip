using Bussiness.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "Juliet";
            person1.LastName = "Capulet";
            person1.DateOfBirthYear = 1591;

            Person person2 = new Person();
            person2.FirstName = "Romeo";
            person2.LastName = "Montague";
            person2.DateOfBirthYear = 1594;


            Person person3 = new Person();
            person3.FirstName = "Aslı";
            person3.LastName = "Kalırka";
            person3.NationalIdentity = 55;
            person3.DateOfBirthYear = 2024;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            pttManager.GiveMask(person2);
            pttManager.GiveMask(person3);
            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Hello!" + isim);
        }
        static int Topla(int sayi1=3, int sayi2=10)
        {
            int sonuc= sayi1 + sayi2;
            Console.WriteLine("Toplam" + sonuc.ToString());
            return sonuc; 
        }

        private static void Degiskenler()
        {
            string message = "WELCOME!";
            double tutar = 10000;
            int sayı = 0;
            bool girisyapildi = false;

            Console.WriteLine(tutar * 1.18);
        }
    
    }

    //public class Person
    //{
    //    //public string name = "Ali";
    //    //public string surname = "Korkmaz";
    //    //public int birthdate = 1995;
    //    //public long tcno = 12345678910;

    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int BirthDate { get; set; }
    //    public long TcNo { get; set; }

    //}





}














//Notlar:
//Classları çıplak bırakma interface ekle. Bağımlılıgını ortadan kaldırır.
//SOLID
//single responsibility: her katman her method her class her if blogu 1 işi yapar
//entities: varlık nesnelerini tutar
//bussiness: iş kurallarını tutar (if blokları)

//bussines altındaki abstract soyut; concrete somut nesneleri tutar

//bir sınıf bir sınıfı new liyorsa, değişikliklerde direnç gözlenir. 
//interface (abstractdaki) classlar için tanımlanmalı. İçinde sadece imzalar çağırılabilir.
//sadece imza koymak bağımlılığı çözmez, 
