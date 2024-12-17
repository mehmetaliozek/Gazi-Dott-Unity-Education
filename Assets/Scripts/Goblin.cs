using UnityEngine;

public class Goblin : MonoBehaviour
{
    // D��man karakterin belirli bir mesafede iki nokta aras�nda hareket etmesini sa�layan script.

    public int range; // D��man�n hareket edece�i mesafe.
    public float speed; // D��man�n hareket h�z�.
    public int health; // D��man�n can de�eri.

    private Vector2 positionA; // D��man�n ba�lang�� pozisyonu.
    private Vector2 positionB; // D��man�n gidece�i di�er pozisyon.
    private Vector2 targetPosition; // �u anki hedef pozisyon.

    public void Start()
    {
        // positionA, d��man�n ilk pozisyonu olarak ayarlan�r.
        positionA = transform.position;

        // positionB, d��man�n hareket edece�i ikinci pozisyon olarak belirlenir.
        // Transform'un yerel �l�e�i (localScale) kullan�larak pozisyon mesafesi hesaplan�r.
        positionB = transform.position + (transform.localScale * range);

        // �lk hedef pozisyon, positionB olarak ayarlan�r.
        targetPosition = positionB;
    }

    public void Update()
    {
        // Her karede d��man�n hareketini kontrol eden metod �a�r�l�r.
        Move();
    }

    private void Move()
    {
        // D��man�n yeni pozisyonunu hesaplar:
        Vector2 newPos = new Vector2(
            Mathf.MoveTowards(transform.position.x, targetPosition.x, speed * Time.deltaTime), // X ekseninde hedefe do�ru ilerler.
            transform.position.y // Y ekseni sabit kal�r.
        );

        // Hesaplanan pozisyon, d��mana atan�r.
        transform.position = newPos;

        // E�er d��man hedef pozisyona �ok yak�nsa:
        if (Mathf.Abs(transform.position.x - targetPosition.x) < 0.1f)
        {
            // E�er mevcut hedef positionA ise hedefi positionB olarak de�i�tir.
            if (targetPosition == positionA)
            {
                targetPosition = positionB;
            }
            // E�er mevcut hedef positionB ise hedefi positionA olarak de�i�tir.
            else if (targetPosition == positionB)
            {
                targetPosition = positionA;
            }

            // Y�n de�i�tirme i�lemini ger�ekle�tir.
            Turn();
        }
    }

    private void Turn()
    {
        // D��man�n bak�� y�n�n� de�i�tirir:
        // E�er d��man�n x �l�e�i 1 ise sola d�ner (-1 yapar).
        if (transform.localScale.x == 1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        // E�er d��man�n x �l�e�i -1 ise sa�a d�ner (1 yapar).
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
