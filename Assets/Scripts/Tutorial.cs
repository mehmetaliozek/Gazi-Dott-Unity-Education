using System.Collections.Generic; // Liste ve koleksiyonlar için gerekli kütüphane.
using UnityEngine; // Unity’nin temel kütüphanesi.

public class Tutorial : MonoBehaviour
{
    // Baþlangýç metodu. Unity'de `Start` metodu, oyun baþladýðýnda bir defa çalýþýr.
    public void Start()
    {
        // **1. Sayýsal Ýþlemler**: Temel matematik iþlemleri.
        int sayi1 = 10; // Tam sayý deðiþkeni tanýmlandý.
        int sayi2 = 20; // Ýkinci tam sayý deðiþkeni tanýmlandý.

        // Toplama iþlemi
        Debug.Log("Topla: " + (sayi1 + sayi2));

        // Çýkarma iþlemi
        Debug.Log("Çýkar: " + (sayi1 - sayi2));

        // Çarpma iþlemi
        Debug.Log("Çarp: " + (sayi1 * sayi2));

        // Bölme iþlemi (sonuç tam sayý olur çünkü `int` kullanýlýyor)
        Debug.Log("Böl: " + (sayi1 / sayi2));

        // Modül (kalan) alma iþlemi
        Debug.Log("Mod alma: " + (sayi1 % sayi2));

        // **2. Ondalýk Sayýlar ile Ýþlemler**: `float` türündeki deðiþkenler.
        float sayi3 = 0.5f; // Ondalýk sayý deðiþkeni.
        float sayi4 = 3.41f; // Ýkinci ondalýk sayý.

        // Toplama iþlemi
        Debug.Log("Topla: " + (sayi3 + sayi4));

        // Çýkarma iþlemi
        Debug.Log("Çýkar: " + (sayi3 - sayi4));

        // Çarpma iþlemi
        Debug.Log("Çarp: " + (sayi3 * sayi4));

        // Bölme iþlemi
        Debug.Log("Böl: " + (sayi3 / sayi4));

        // Mod alma iþlemi (float için desteklenmez; çýkarýlabilir)

        // **3. String Ýþlemleri**: Metinsel ifadeler.
        string metin1 = "Merhaba"; // Metinsel bir deðiþken.

        // String deðeri yazdýrma
        Debug.Log(metin1);

        // **4. Boolean (Mantýksal) Deðerler**: `true` veya `false` deðerleri.
        bool durum1 = true; // Mantýksal doðru.
        bool durum2 = false; // Mantýksal yanlýþ.

        // **5. Deðiþkenler ile Karþýlaþtýrmalar**: Koþullarýn kontrolü.
        string isim = "MaliPrime"; // String deðiþkeni.
        float hiz = 2.5f; // Ondalýk bir deðiþken.
        int yas = 20; // Tam sayý deðiþkeni.

        // Yaþ deðerini kontrol etme
        if (yas == 20) // Eþitlik kontrolü.
        {
            Debug.Log("Yaþ 20'ye eþit.");
        }
        if (yas != 30) // Eþit olmama kontrolü.
        {
            Debug.Log("Yaþ 30'a eþit deðil.");
        }
        if (yas < 25) // Küçüklük kontrolü.
        {
            Debug.Log("Yaþ 25'ten küçük.");
        }
        if (yas >= 20) // Büyük veya eþitlik kontrolü.
        {
            Debug.Log("Yaþ 20'ye eþit veya büyük.");
        }

        // **6. If-Else If-Else Yapýsý**: Çoklu koþullar.
        int sayi5 = 35;

        if (sayi5 > 90)
        {
            Debug.Log("90'dan büyük");
        }
        else if (sayi5 > 50)
        {
            Debug.Log("50'den büyük");
        }
        else if (sayi5 > 30)
        {
            Debug.Log("30'dan büyük");
        }
        else
        {
            Debug.Log("30'dan küçük");
        }

        // **7. Switch-Case Yapýsý**: Sabit deðerlerle koþullar.
        string metin2 = "eajhhjsfdbhfbfsd";

        switch (metin2)
        {
            case "hoþçakal":
                Debug.Log("Case 1");
                break;
            case "merhaba":
                Debug.Log("Case 2");
                break;
            default:
                Debug.Log("Tanýmlanmamýþ Case");
                break;
        }

        // **8. Dizi (Array) Kullanýmý**: Sabit boyutlu koleksiyonlar.
        int[] dizi1 = new int[10]; // 10 elemanlý bir tam sayý dizisi.
        dizi1[0] = 20; // Ýlk eleman.
        dizi1[1] = 30; // Ýkinci eleman.
        dizi1[2] = 40; // Üçüncü eleman.
        dizi1[9] = 50; // Son eleman.

        // Dizi elemanlarýný yazdýrma
        Debug.Log(dizi1[0]); // 20
        // Debug.Log(dizi1[100]); // Hata verir: Dizi sýnýrý dýþýnda.

        // **9. String Dizisi Örneði**: Metinlerden oluþan diziler.
        string[] günler = {
            "Pazartesi", "Salý", "Çarþamba", "Perþembe", "Cuma", "Cumartesi", "Pazar"
        };

        // Dizi elemanýný yazdýrma
        Debug.Log(günler[6]); // Pazar

        // **10. Liste (List) Kullanýmý**: Dinamik koleksiyonlar.
        List<string> stringListesi = new List<string>(); // String listesi oluþturma.

        // Listeye eleman ekleme
        stringListesi.Add("Naber");
        stringListesi.Add("Naber1");

        // Elemanlarý döngüyle yazdýrma
        foreach (string item in stringListesi)
        {
            Debug.Log(item);
        }

        // **11. Fonksiyon Kullanýmý**: Kod tekrarý için fonksiyonlar.
        Fonksiyon1(); // Ýlk fonksiyon çaðrýsý.

        Fonskiyon2("Deneme 1"); // Parametreli fonksiyon.

        int carpim = Fonksiyon3(); // Deðer döndüren fonksiyon.
        Debug.Log(carpim);

        Debug.Log(Fonksiyon4(5, 8)); // Parametre alýp dönen fonksiyon.
    }

    public void Update()
    {
        // Oyun sýrasýnda sürekli çalýþan metod.
    }

    void Fonksiyon1()
    {
        Debug.Log("Fonksiyon 1");
    }

    void Fonskiyon2(string metin)
    {
        Debug.Log("Fonksiyon2: " + metin);
    }

    int Fonksiyon3()
    {
        int sayi1 = 10, sayi2 = 20;
        return sayi1 * sayi2; // Çarpým sonucu döndürülüyor.
    }

    int Fonksiyon4(int sayi1, int sayi2)
    {
        return sayi1 * sayi2; // Parametrelerin çarpýmý.
    }
}
