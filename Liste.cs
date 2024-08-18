internal class Program
{
    public class Ogrenci
    {
        // Id adında bir özellik tanımlıyoruz.
        // Bu özellik, her bir öğrenci için benzersiz bir kimlik numarası (Id) tutar.
        public int Id { get; set; }

        // Name adında bir özellik tanımlıyoruz.
        // Bu özellik, öğrencinin adını ve soyadını (tam adını) tutar.
        public string Name { get; set; }

        // Notlar adında bir özellik tanımlıyoruz.
        // Bu özellik, öğrencinin aldığı notları temsil eder.
        // Burada, sadece bir not tutuluyor; ancak bu özellik,
        // farklı şekilde genişletilerek birden fazla notu da tutabilir.
        public int Notlar { get; set; }
    }

    /*
        Erişim Yöntemleri (get; set;):
        get; kısmı, özelliğin değerini almayı sağlar. Yani, bu özellik kullanıldığında, o özellikte saklanan değeri geri döndürür.
        set; kısmı, özelliğin değerini ayarlamayı sağlar. Yani, bu özellik kullanıldığında, ona yeni bir değer atanabilir.
    */


    static void Main(string[] args)
    {
        //Add fonksiyonu ile listeye daha sonradan eleman ekleme
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        //Liste oluşturulurken eleman ekleme
        List<String> list2 = new List<String> {"Samet","Veli","Ahmet"};
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
        foreach(string s in list2) {  Console.WriteLine(s); }

        Console.WriteLine(list[0] +" "+ list2[0]);
        Console.WriteLine("\n");

        //Collection List Örnekleri
        var ogrenci = new List<Ogrenci>
        {
            new Ogrenci 
            {
                Id = 1 , 
                Name = "Samet YILMAZ", 
                Notlar = 20
            },
            new Ogrenci 
            {
                Id = 2 , 
                Name = "Veli CAN" , 
                Notlar = 30
            }
        };

        foreach (Ogrenci o in ogrenci) 
        { 
            Console.WriteLine($"Id : {o.Id} \nAd Soyad : {o.Name}\nNotlar : {o.Notlar}"); 
        }

        Console.ReadLine();
    }
}