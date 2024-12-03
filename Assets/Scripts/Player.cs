using UnityEngine;

public class Player : MonoBehaviour
{
    // Rigidbody2D bileþeni referansý
    public Rigidbody2D rigidbody;

    public void Start()
    {
        // Oyun baþladýðýnda çalýþacak olan baþlangýç kodlarý burada yer alýr.
    }

    public void Update()
    {
        // Yatay eksendeki oyuncu girdi deðerini alýyoruz.
        float x = Input.GetAxis("Horizontal");
        // "Horizontal" Unity’nin varsayýlan giriþ eksenidir ve genellikle A-D veya Sol-Sað ok tuþlarýyla kontrol edilir.

        // Hareket vektörü oluþturuluyor.
        Vector2 vector = new Vector2(x, rigidbody.linearVelocityY) * 5;
        // Hareket hýzý 5 ile çarpýlýyor ve mevcut dikey hýz korunuyor.

        // **1. transform.Translate**
        // `transform.Translate` nesnenin pozisyonunu doðrudan deðiþtirir.
        // Fizik motorunu dikkate almaz, bu nedenle çarpýþmalar gibi fizik olaylarýný iþlemez.
        // Yorum satýrýndan kaldýrarak deneyebilirsiniz:
        // transform.Translate(vector * Time.deltaTime);
        // Time.deltaTime kullanarak frame-rate baðýmsýz hareket elde edilir.

        // **2. Rigidbody2D.AddForce**
        // `AddForce` bir kuvvet uygular ve fizik motorunu dikkate alýr.
        // Bu yöntem, hýzlandýrýlmýþ hareketler veya atalet gibi fizik davranýþlarýný taklit eder.
        // Yorum satýrýndan kaldýrarak deneyebilirsiniz:
        // rigidbody.AddForce(vector);

        // **3. Rigidbody2D.velocity**
        // `velocity` nesnenin anlýk hýzýný belirler ve hareketi doðrudan kontrol eder.
        // Fizik motoruyla uyumludur ancak hýz, kuvvet uygulamak yerine doðrudan deðiþtirilir.
        rigidbody.linearVelocity = vector;

        // Not: Yukarýdaki üç yöntemden yalnýzca biri ayný anda kullanýlmalýdýr.
        // Her biri farklý kullaným durumlarýna uygundur.
    }

    // Çarpýþma olaylarýný iþlemek için bir metot.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpýþma olduðunda tetiklenecek iþlemler buraya yazýlabilir.
    }
}
