using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // Aþaðýdaki kodlarý çalýþtýrmak istediðiniz kodlar dýþýndakileri açýklama satýrý yapip tek tek incelemenizi öneririm
    public void Start()
    {
        // 1. Sayýsal iþlemler
        int sayi1 = 10;
        int sayi2 = 20;

        // Toplama iþlemi
        Debug.Log("Topla: " + (sayi1 + sayi2));

        // Çýkarma iþlemi
        Debug.Log("Çýkar: " + (sayi1 - sayi2));

        // Çarpma iþlemi
        Debug.Log("Çarp: " + (sayi1 * sayi2));

        // Bölme iþlemi
        Debug.Log("Böl: " + (sayi1 / sayi2));

        // Modül (kalan) alma iþlemi
        Debug.Log("Mod alma: " + (sayi1 % sayi2));

        // 2. Ondalýk sayýlar ile iþlemler
        float sayi3 = 0.5f;
        float sayi4 = 3.41f;

        // Toplama iþlemi
        Debug.Log("Topla: " + (sayi3 + sayi4));

        // Çýkarma iþlemi
        Debug.Log("Çýkar: " + (sayi3 - sayi4));

        // Çarpma iþlemi
        Debug.Log("Çarp: " + (sayi3 * sayi4));

        // Bölme iþlemi
        Debug.Log("Böl: " + (sayi3 / sayi4));

        // Modül alma iþlemi (ondalýk sayýlar için)
        Debug.Log("Mod alma: " + (sayi3 % sayi4));

        // 3. String iþlemleri
        string metin1 = "Merhaba";

        // String deðeri yazdýrma
        Debug.Log(metin1);

        // 4. Boolean (Mantýksal) deðerler
        bool durum1 = true;
        bool durum2 = false;

        // 5. Deðiþkenler ile karþýlaþtýrmalar
        string isim = "MaliPrime";
        float hiz = 2.5f;
        int yas = 20;

        // Eþitlik ve karþýlaþtýrma örnekleri
        if (yas == 20)
        {
            Debug.Log("Yaþ 20'ye eþit.");
        }
        if (yas != 30)
        {
            Debug.Log("Yaþ 30'a eþit deðil.");
        }
        if (yas < 25)
        {
            Debug.Log("Yaþ 25'ten küçük.");
        }
        if (yas >= 20)
        {
            Debug.Log("Yaþ 20'ye eþit veya büyük.");
        }

        // 6. if-else if-else yapýsý
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

        // 7. Switch-case yapýsý
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

        // Zorluk seviyesi için switch örneði
        string zorluk = "kolay";
        switch (zorluk)
        {
            case "kolay":
                Debug.Log("Kolay seçtiniz");
                break;
            case "orta":
                Debug.Log("Orta seçtiniz");
                break;
            case "zor":
                Debug.Log("Zor seçtiniz");
                break;
        }

        // 8. Dizi kullanýmý (Array)
        int[] dizi1 = new int[10]; // 10 elemanlý bir dizi oluþturuluyor
        dizi1[0] = 20; // Ýlk elemana 20 atanýyor
        dizi1[1] = 30; // Ýkinci elemana 30 atanýyor
        dizi1[2] = 40; // Üçüncü elemana 40 atanýyor
        dizi1[9] = 50; // Son elemana 50 atanýyor

        // Dizi elemanlarýný yazdýrma
        Debug.Log(dizi1[0]); // 20 yazdýrýlýr
        Debug.Log(dizi1[100]); // Burada hata alýrsýnýz, çünkü dizi sadece 10 elemanlýdýr.

        // 9. String dizisi örneði
        string[] günler = {
            "Pazartesi", "Salý", "Çarþamba", "Perþembe", "Cuma", "Cumartesi", "Pazar"
        };

        // Dizi elemanýný yazdýrma
        Debug.Log(günler[6]); // Pazar yazdýrýlýr

        // 10. Liste (List) kullanýmý
        List<string> stringListesi = new List<string>();

        // Listeye eleman ekleme
        stringListesi.Add("Naber");

        // Liste elemanýný yazdýrma
        Debug.Log(stringListesi[0]); // "Naber" yazdýrýlýr
    }

    public void Update()
    {

    }
}
