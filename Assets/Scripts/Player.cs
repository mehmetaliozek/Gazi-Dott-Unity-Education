using UnityEngine;

public class Player : MonoBehaviour
{
    // Rigidbody2D bile�eni referans�
    public Rigidbody2D rigidbody;

    public void Start()
    {
        // Oyun ba�lad���nda �al��acak olan ba�lang�� kodlar� burada yer al�r.
    }

    public void Update()
    {
        // Yatay eksendeki oyuncu girdi de�erini al�yoruz.
        float x = Input.GetAxis("Horizontal");
        // "Horizontal" Unity�nin varsay�lan giri� eksenidir ve genellikle A-D veya Sol-Sa� ok tu�lar�yla kontrol edilir.

        // Hareket vekt�r� olu�turuluyor.
        Vector2 vector = new Vector2(x, rigidbody.linearVelocityY) * 5;
        // Hareket h�z� 5 ile �arp�l�yor ve mevcut dikey h�z korunuyor.

        // **1. transform.Translate**
        // `transform.Translate` nesnenin pozisyonunu do�rudan de�i�tirir.
        // Fizik motorunu dikkate almaz, bu nedenle �arp��malar gibi fizik olaylar�n� i�lemez.
        // Yorum sat�r�ndan kald�rarak deneyebilirsiniz:
        // transform.Translate(vector * Time.deltaTime);
        // Time.deltaTime kullanarak frame-rate ba��ms�z hareket elde edilir.

        // **2. Rigidbody2D.AddForce**
        // `AddForce` bir kuvvet uygular ve fizik motorunu dikkate al�r.
        // Bu y�ntem, h�zland�r�lm�� hareketler veya atalet gibi fizik davran��lar�n� taklit eder.
        // Yorum sat�r�ndan kald�rarak deneyebilirsiniz:
        // rigidbody.AddForce(vector);

        // **3. Rigidbody2D.velocity**
        // `velocity` nesnenin anl�k h�z�n� belirler ve hareketi do�rudan kontrol eder.
        // Fizik motoruyla uyumludur ancak h�z, kuvvet uygulamak yerine do�rudan de�i�tirilir.
        rigidbody.linearVelocity = vector;

        // Not: Yukar�daki �� y�ntemden yaln�zca biri ayn� anda kullan�lmal�d�r.
        // Her biri farkl� kullan�m durumlar�na uygundur.
    }

    // �arp��ma olaylar�n� i�lemek i�in bir metot.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �arp��ma oldu�unda tetiklenecek i�lemler buraya yaz�labilir.
    }
}
