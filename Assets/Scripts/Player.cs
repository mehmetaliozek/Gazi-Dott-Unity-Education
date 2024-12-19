using UnityEngine;

public class Player : MonoBehaviour
{
    // Rigidbody2D bileşeni referansı
    private Rigidbody2D rb;
    // Animator bileşeni referansı
    public Animator animator;

    // Oyuncunun hareket hızı
    public float speed;
    // Oyuncunun zıplama kuvveti
    public float jumpForce;
    // Zemin kontrolü için kullanılan nesne
    public GameObject groundCheck;
    // Zemin olarak kabul edilen katman
    public LayerMask groundLayer;

    // Çift zıplama hakkı kontrolü
    private bool isDoubleJump = false;

    public int health;
    private bool isDeath = false;

    public GameObject pausePanel;

    // Oyunun başlangıcında çalışacak olan kodlar
    public void Start()
    {
        // Rigidbody2D bileşeni atanıyor
        rb = GetComponent<Rigidbody2D>();
    }

    // Her karede çalışacak kodlar
    public void Update()
    {
        if (isDeath) return;
        // Hareket fonksiyonu çağırılıyor
        MovementWithVelocity();
        // Zıplama fonksiyonu çağırılıyor
        DoubleJump();
        // Hız arttırma fonksiyonu çağırılıyor
        HighSpeed();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (Time.timeScale)
            {
                case 0:
                    Time.timeScale = 1;
                    pausePanel.SetActive(false);
                    break;
                case 1:
                    Time.timeScale = 0;
                    pausePanel.SetActive(true);
                    break;
            }
        }
    }

    // Velocity ile hareket fonksiyonu
    public void MovementWithVelocity()
    {
        // Yatay eksende oyuncu girişini alıyoruz
        float x = Input.GetAxis("Horizontal") * speed;
        // Hareket vektörü oluşturuluyor
        Vector2 vector = new Vector2(x, rb.linearVelocity.y);

        // Hızı doğrudan değiştiriyoruz
        rb.linearVelocity = vector;

        // Animator'da hareket hızına göre parametreyi güncelliyoruz
        animator.SetFloat("Velocity", Mathf.Abs(x));

        // Karakterin yüz yönünü ayarlıyoruz
        if (x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (x < 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
    }

    // AddForce ile hareket fonksiyonu
    public void MovementWithAddForce()
    {
        // Yatay eksende oyuncu girişini alıyoruz
        float x = Input.GetAxis("Horizontal");
        // AddForce kullanarak kuvvet uyguluyoruz
        rb.AddForce(new Vector2(x * speed, 0));
    }

    // Zıplama fonksiyonu
    public void Jump()
    {
        // Karakterin zeminde olup olmadığını kontrol ediyoruz
        bool isGroundCheck = Physics2D.OverlapPoint(groundCheck.transform.position, groundLayer);

        // Eğer oyuncu zeminde ve Space tuşuna basılmışsa
        if (Input.GetKeyDown(KeyCode.Space) && isGroundCheck)
        {
            // Zıplama kuvveti uygulanıyor
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // Animator'da zıplama durumunu güncelliyoruz
        animator.SetBool("IsJumping", !isGroundCheck);
    }

    // Çift zıplama fonksiyonu
    public void DoubleJump()
    {
        // Karakterin zeminde olup olmadığını kontrol ediyoruz
        bool isGroundCheck = Physics2D.OverlapPoint(groundCheck.transform.position, groundLayer);

        // Eğer oyuncu zeminde ve Space tuşuna basılmışsa
        if (Input.GetKeyDown(KeyCode.Space) && isGroundCheck)
        {
            // İlk zıplama kuvveti uygulanıyor
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            // Çift zıplama hakkı aktif hale getiriliyor
            isDoubleJump = true;
        }
        // Eğer oyuncu havadaysa ve çift zıplama hakkı varsa
        else if (Input.GetKeyDown(KeyCode.Space) && isDoubleJump)
        {
            // İkinci kez zıplama kuvveti uygulanıyor
            rb.AddForce(Vector2.up / 1.5f * jumpForce, ForceMode2D.Impulse);
            // Çift zıplama hakkı devre dışı bırakılıyor
            isDoubleJump = false;
        }

        // Animator'da zıplama durumunu güncelliyoruz
        animator.SetBool("IsJumping", !isGroundCheck);
    }

    // Hız arttırma fonksiyonu
    public void HighSpeed()
    {
        // Sol Shift tuşuna basıldığında hız iki katına çıkarılıyor
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
        // Sol Shift tuşu bırakıldığında hız normale dönüyor
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
    }

    // Translate ile hareket fonksiyonu
    public void MovementWithTranslate()
    {
        // Yatay eksende oyuncu girişini alıyoruz
        float x = Input.GetAxis("Horizontal");
        // Hareket vektörü oluşturuluyor
        Vector2 vector = new Vector2(x * 5, 0);

        // Translate ile pozisyon doğrudan değiştiriliyor
        transform.Translate(vector * Time.deltaTime);
    }

    // Oyuncunun düşmanla çarpıştığında can kaybetmesini ve ölüm durumunu kontrol eden metod.

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Eğer çarpışılan nesnenin etiketi "Enemy" ise:
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Oyuncunun canını 5 azalt.
            health -= 5;

            // Oyuncunun "Hit" animasyonunu oynatmak için "Hit" tetikleyicisini (Trigger) aktif et.
            animator.SetTrigger("Hit");

            // Eğer can 0 veya altına düşerse:
            if (health <= 0)
            {
                // Oyuncunun öldüğünü belirtmek için isDeath değişkenini true yap.
                isDeath = true;

                // "IsDeath" parametresini true yaparak ölüm animasyonunu başlat.
                animator.SetBool("IsDeath", isDeath);
            }
        }
    }

}
