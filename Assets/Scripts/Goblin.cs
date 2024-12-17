using UnityEngine;

public class Goblin : MonoBehaviour
{
    // Düþman karakterin belirli bir mesafede iki nokta arasýnda hareket etmesini saðlayan script.

    public int range; // Düþmanýn hareket edeceði mesafe.
    public float speed; // Düþmanýn hareket hýzý.
    public int health; // Düþmanýn can deðeri.

    private Vector2 positionA; // Düþmanýn baþlangýç pozisyonu.
    private Vector2 positionB; // Düþmanýn gideceði diðer pozisyon.
    private Vector2 targetPosition; // Þu anki hedef pozisyon.

    public void Start()
    {
        // positionA, düþmanýn ilk pozisyonu olarak ayarlanýr.
        positionA = transform.position;

        // positionB, düþmanýn hareket edeceði ikinci pozisyon olarak belirlenir.
        // Transform'un yerel ölçeði (localScale) kullanýlarak pozisyon mesafesi hesaplanýr.
        positionB = transform.position + (transform.localScale * range);

        // Ýlk hedef pozisyon, positionB olarak ayarlanýr.
        targetPosition = positionB;
    }

    public void Update()
    {
        // Her karede düþmanýn hareketini kontrol eden metod çaðrýlýr.
        Move();
    }

    private void Move()
    {
        // Düþmanýn yeni pozisyonunu hesaplar:
        Vector2 newPos = new Vector2(
            Mathf.MoveTowards(transform.position.x, targetPosition.x, speed * Time.deltaTime), // X ekseninde hedefe doðru ilerler.
            transform.position.y // Y ekseni sabit kalýr.
        );

        // Hesaplanan pozisyon, düþmana atanýr.
        transform.position = newPos;

        // Eðer düþman hedef pozisyona çok yakýnsa:
        if (Mathf.Abs(transform.position.x - targetPosition.x) < 0.1f)
        {
            // Eðer mevcut hedef positionA ise hedefi positionB olarak deðiþtir.
            if (targetPosition == positionA)
            {
                targetPosition = positionB;
            }
            // Eðer mevcut hedef positionB ise hedefi positionA olarak deðiþtir.
            else if (targetPosition == positionB)
            {
                targetPosition = positionA;
            }

            // Yön deðiþtirme iþlemini gerçekleþtir.
            Turn();
        }
    }

    private void Turn()
    {
        // Düþmanýn bakýþ yönünü deðiþtirir:
        // Eðer düþmanýn x ölçeði 1 ise sola döner (-1 yapar).
        if (transform.localScale.x == 1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        // Eðer düþmanýn x ölçeði -1 ise saða döner (1 yapar).
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
