using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // A�a��daki kodlar� �al��t�rmak istedi�iniz kodlar d���ndakileri a��klama sat�r� yapip tek tek incelemenizi �neririm
    public void Start()
    {
        // 1. Say�sal i�lemler
        int sayi1 = 10;
        int sayi2 = 20;

        // Toplama i�lemi
        Debug.Log("Topla: " + (sayi1 + sayi2));

        // ��karma i�lemi
        Debug.Log("��kar: " + (sayi1 - sayi2));

        // �arpma i�lemi
        Debug.Log("�arp: " + (sayi1 * sayi2));

        // B�lme i�lemi
        Debug.Log("B�l: " + (sayi1 / sayi2));

        // Mod�l (kalan) alma i�lemi
        Debug.Log("Mod alma: " + (sayi1 % sayi2));

        // 2. Ondal�k say�lar ile i�lemler
        float sayi3 = 0.5f;
        float sayi4 = 3.41f;

        // Toplama i�lemi
        Debug.Log("Topla: " + (sayi3 + sayi4));

        // ��karma i�lemi
        Debug.Log("��kar: " + (sayi3 - sayi4));

        // �arpma i�lemi
        Debug.Log("�arp: " + (sayi3 * sayi4));

        // B�lme i�lemi
        Debug.Log("B�l: " + (sayi3 / sayi4));

        // Mod�l alma i�lemi (ondal�k say�lar i�in)
        Debug.Log("Mod alma: " + (sayi3 % sayi4));

        // 3. String i�lemleri
        string metin1 = "Merhaba";

        // String de�eri yazd�rma
        Debug.Log(metin1);

        // 4. Boolean (Mant�ksal) de�erler
        bool durum1 = true;
        bool durum2 = false;

        // 5. De�i�kenler ile kar��la�t�rmalar
        string isim = "MaliPrime";
        float hiz = 2.5f;
        int yas = 20;

        // E�itlik ve kar��la�t�rma �rnekleri
        if (yas == 20)
        {
            Debug.Log("Ya� 20'ye e�it.");
        }
        if (yas != 30)
        {
            Debug.Log("Ya� 30'a e�it de�il.");
        }
        if (yas < 25)
        {
            Debug.Log("Ya� 25'ten k���k.");
        }
        if (yas >= 20)
        {
            Debug.Log("Ya� 20'ye e�it veya b�y�k.");
        }

        // 6. if-else if-else yap�s�
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

        // 7. Switch-case yap�s�
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

        // Zorluk seviyesi i�in switch �rne�i
        string zorluk = "kolay";
        switch (zorluk)
        {
            case "kolay":
                Debug.Log("Kolay se�tiniz");
                break;
            case "orta":
                Debug.Log("Orta se�tiniz");
                break;
            case "zor":
                Debug.Log("Zor se�tiniz");
                break;
        }

        // 8. Dizi kullan�m� (Array)
        int[] dizi1 = new int[10]; // 10 elemanl� bir dizi olu�turuluyor
        dizi1[0] = 20; // �lk elemana 20 atan�yor
        dizi1[1] = 30; // �kinci elemana 30 atan�yor
        dizi1[2] = 40; // ���nc� elemana 40 atan�yor
        dizi1[9] = 50; // Son elemana 50 atan�yor

        // Dizi elemanlar�n� yazd�rma
        Debug.Log(dizi1[0]); // 20 yazd�r�l�r
        Debug.Log(dizi1[100]); // Burada hata al�rs�n�z, ��nk� dizi sadece 10 elemanl�d�r.

        // 9. String dizisi �rne�i
        string[] g�nler = {
            "Pazartesi", "Sal�", "�ar�amba", "Per�embe", "Cuma", "Cumartesi", "Pazar"
        };

        // Dizi eleman�n� yazd�rma
        Debug.Log(g�nler[6]); // Pazar yazd�r�l�r

        // 10. Liste (List) kullan�m�
        List<string> stringListesi = new List<string>();

        // Listeye eleman ekleme
        stringListesi.Add("Naber");

        // Liste eleman�n� yazd�rma
        Debug.Log(stringListesi[0]); // "Naber" yazd�r�l�r
    }

    public void Update()
    {

    }
}
