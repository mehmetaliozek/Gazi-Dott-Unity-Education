using UnityEngine;

public class Player : MonoBehaviour
{
    // Rigidbody2D bileşeni referansı
    private Rigidbody2D rigidbody;

    public float speed;
    public float jumpForce;
    public GameObject zeminKontrol;
    public LayerMask groundLayer;

    public void Start()
    {
        // Oyun başladığında çalışacak olan başlangıç kodları burada yer alır.
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        // Kullanıcı girişlerini sürekli kontrol et ve ilgili hareket fonksiyonlarını çağır.
        HandleMovementWithVelocity();
        HandleJump();
    }

    // Velocity ile hareket fonksiyonu
    public void HandleMovementWithVelocity()
    {
        // Yatay eksendeki oyuncu girdi değerini alıyoruz.
        float x = Input.GetAxis("Horizontal") * speed;
        // Hareket vektörü oluşturuluyor.
        Vector2 vector = new Vector2(x , rigidbody.linearVelocityY);

        // Hızı doğrudan değiştiriyoruz.
        rigidbody.linearVelocity = vector;

        // Not: Velocity doğrudan hız belirler, fizik kurallarını uygular.
    }

    // AddForce ile hareket fonksiyonu
    public void HandleMovementWithAddForce()
    {
        float x = Input.GetAxis("Horizontal");
        // AddForce kullanılarak kuvvet uygulanıyor.
        rigidbody.AddForce(new Vector2(x * 5, 0));

        // Not: AddForce ile hareket, hızlanma ve atalet etkilerini dikkate alır.
    }

    // Zıplama fonksiyonu
    public void HandleJump()
    {
        // Zemin kontrolü
        bool zemindemi = Physics2D.OverlapPoint(zeminKontrol.transform.position, groundLayer);

        // Eğer oyuncu zemin üzerindeyse ve "Space" tuşuna basıldıysa
        if (Input.GetKeyDown(KeyCode.Space) && zemindemi)
        {
            // Zıplama kuvveti uygulanıyor.
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            // Not: AddForce ile zıplama fizik motorunu kullanır.
        }
    }

    // Translate ile hareket fonksiyonu
    public void HandleMovementWithTranslate()
    {
        float x = Input.GetAxis("Horizontal");
        // Hareket vektörü oluşturuluyor.
        Vector2 vector = new Vector2(x * 5, 0);

        // Translate ile pozisyon doğrudan değiştiriliyor.
        transform.Translate(vector * Time.deltaTime);

        // Not: Translate fizik motorunu dikkate almaz, çarpışmaları işlemez.
    }
}
