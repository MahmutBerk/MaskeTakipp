// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //Degiskenler();

        SelamVer( "Mahmut");
        SelamVer( "Berk");
        SelamVer();
        int sonuc1 = Topla(3, 5);

        string[] students = new string[3];
        students[0] = "Mahmut";
        students[1] = "Berk";
        students[2] = "Furkan";

       // students = new string[4];
       // students[3] = "BERko";


        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }

        string[] city  =  { "Ankara", "İstanbul", "İzmir" };
        string[] city1 =  { "Konya", "Kahramanmaras", "Sinop" };

        city1 = city;
        city[0] = "Adana";
        Console.WriteLine(city1[0]);

        Person person1 = new Person ();
        person1.FirstName = "Mahmut";
        person1.LastName = "BERK";
        person1.DateOfBirthYear = 1999;
        person1.NationalIdentity = 123;

        Person person2 = new Person();
        person2.FirstName = "Berk";



        foreach (string sehir in city)
        {
            Console.WriteLine(sehir);
        }

        List<string> sehirler = new List<string> { "Ankara1", "İzmir1", "İstanbul1" };
        sehirler.Add("Maraş");
        foreach (string ct in sehirler)
        {
            Console.WriteLine(ct);
        }

       PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);



        Console.ReadLine();

    }

    private static void Degiskenler()
    {
        string message = "Merhaba";
        double tutar = 100000;
        int say = 100;
        bool girisyapmismi = false;

        string name = "Mahmut";
        string surname = "Berk";
        int year = 1999;
        long tc = 12345678910;

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(message);
        Console.WriteLine(message);
        Console.WriteLine(message);
    }

    static void SelamVer(String isim = "Null")
    {
        Console.WriteLine("MERHABA" +  isim);
    }

    static int Topla (int say1, int say2)
    {
        int sonuc = say1 + say2;
        Console.WriteLine("Toplam : " +  sonuc);
        return sonuc;
    }
}