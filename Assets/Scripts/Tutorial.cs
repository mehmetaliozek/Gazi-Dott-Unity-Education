using System.Collections.Generic; // Liste ve koleksiyonlar i�in gerekli k�t�phane.
using UnityEngine; // Unity�nin temel k�t�phanesi.

public class Tutorial : MonoBehaviour
{
    // Ba�lang�� metodu. Unity'de `Start` metodu, oyun ba�lad���nda bir defa �al���r.
    public void Start()
    {
        // **1. Say�sal ��lemler**: Temel matematik i�lemleri.
        int sayi1 = 10; // Tam say� de�i�keni tan�mland�.
        int sayi2 = 20; // �kinci tam say� de�i�keni tan�mland�.

        // Toplama i�lemi
        Debug.Log("Topla: " + (sayi1 + sayi2));

        // ��karma i�lemi
        Debug.Log("��kar: " + (sayi1 - sayi2));

        // �arpma i�lemi
        Debug.Log("�arp: " + (sayi1 * sayi2));

        // B�lme i�lemi (sonu� tam say� olur ��nk� `int` kullan�l�yor)
        Debug.Log("B�l: " + (sayi1 / sayi2));

        // Mod�l (kalan) alma i�lemi
        Debug.Log("Mod alma: " + (sayi1 % sayi2));

        // **2. Ondal�k Say�lar ile ��lemler**: `float` t�r�ndeki de�i�kenler.
        float sayi3 = 0.5f; // Ondal�k say� de�i�keni.
        float sayi4 = 3.41f; // �kinci ondal�k say�.

        // Toplama i�lemi
        Debug.Log("Topla: " + (sayi3 + sayi4));

        // ��karma i�lemi
        Debug.Log("��kar: " + (sayi3 - sayi4));

        // �arpma i�lemi
        Debug.Log("�arp: " + (sayi3 * sayi4));

        // B�lme i�lemi
        Debug.Log("B�l: " + (sayi3 / sayi4));

        // Mod alma i�lemi (float i�in desteklenmez; ��kar�labilir)

        // **3. String ��lemleri**: Metinsel ifadeler.
        string metin1 = "Merhaba"; // Metinsel bir de�i�ken.

        // String de�eri yazd�rma
        Debug.Log(metin1);

        // **4. Boolean (Mant�ksal) De�erler**: `true` veya `false` de�erleri.
        bool durum1 = true; // Mant�ksal do�ru.
        bool durum2 = false; // Mant�ksal yanl��.

        // **5. De�i�kenler ile Kar��la�t�rmalar**: Ko�ullar�n kontrol�.
        string isim = "MaliPrime"; // String de�i�keni.
        float hiz = 2.5f; // Ondal�k bir de�i�ken.
        int yas = 20; // Tam say� de�i�keni.

        // Ya� de�erini kontrol etme
        if (yas == 20) // E�itlik kontrol�.
        {
            Debug.Log("Ya� 20'ye e�it.");
        }
        if (yas != 30) // E�it olmama kontrol�.
        {
            Debug.Log("Ya� 30'a e�it de�il.");
        }
        if (yas < 25) // K���kl�k kontrol�.
        {
            Debug.Log("Ya� 25'ten k���k.");
        }
        if (yas >= 20) // B�y�k veya e�itlik kontrol�.
        {
            Debug.Log("Ya� 20'ye e�it veya b�y�k.");
        }

        // **6. If-Else If-Else Yap�s�**: �oklu ko�ullar.
        int sayi5 = 35;

        if (sayi5 > 90)
        {
            Debug.Log("90'dan b�y�k");
        }
        else if (sayi5 > 50)
        {
            Debug.Log("50'den b�y�k");
        }
        else if (sayi5 > 30)
        {
            Debug.Log("30'dan b�y�k");
        }
        else
        {
            Debug.Log("30'dan k���k");
        }

        // **7. Switch-Case Yap�s�**: Sabit de�erlerle ko�ullar.
        string metin2 = "eajhhjsfdbhfbfsd";

        switch (metin2)
        {
            case "ho��akal":
                Debug.Log("Case 1");
                break;
            case "merhaba":
                Debug.Log("Case 2");
                break;
            default:
                Debug.Log("Tan�mlanmam�� Case");
                break;
        }

        // **8. Dizi (Array) Kullan�m�**: Sabit boyutlu koleksiyonlar.
        int[] dizi1 = new int[10]; // 10 elemanl� bir tam say� dizisi.
        dizi1[0] = 20; // �lk eleman.
        dizi1[1] = 30; // �kinci eleman.
        dizi1[2] = 40; // ���nc� eleman.
        dizi1[9] = 50; // Son eleman.

        // Dizi elemanlar�n� yazd�rma
        Debug.Log(dizi1[0]); // 20
        // Debug.Log(dizi1[100]); // Hata verir: Dizi s�n�r� d���nda.

        // **9. String Dizisi �rne�i**: Metinlerden olu�an diziler.
        string[] g�nler = {
            "Pazartesi", "Sal�", "�ar�amba", "Per�embe", "Cuma", "Cumartesi", "Pazar"
        };

        // Dizi eleman�n� yazd�rma
        Debug.Log(g�nler[6]); // Pazar

        // **10. Liste (List) Kullan�m�**: Dinamik koleksiyonlar.
        List<string> stringListesi = new List<string>(); // String listesi olu�turma.

        // Listeye eleman ekleme
        stringListesi.Add("Naber");
        stringListesi.Add("Naber1");

        // Elemanlar� d�ng�yle yazd�rma
        foreach (string item in stringListesi)
        {
            Debug.Log(item);
        }

        // **11. Fonksiyon Kullan�m�**: Kod tekrar� i�in fonksiyonlar.
        Fonksiyon1(); // �lk fonksiyon �a�r�s�.

        Fonskiyon2("Deneme 1"); // Parametreli fonksiyon.

        int carpim = Fonksiyon3(); // De�er d�nd�ren fonksiyon.
        Debug.Log(carpim);

        Debug.Log(Fonksiyon4(5, 8)); // Parametre al�p d�nen fonksiyon.
    }

    public void Update()
    {
        // Oyun s�ras�nda s�rekli �al��an metod.
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
        return sayi1 * sayi2; // �arp�m sonucu d�nd�r�l�yor.
    }

    int Fonksiyon4(int sayi1, int sayi2)
    {
        return sayi1 * sayi2; // Parametrelerin �arp�m�.
    }
}
