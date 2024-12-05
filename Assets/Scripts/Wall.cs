using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start, MonoBehaviour ilk olu�turuldu�unda ve Update'den �nce bir kez �a�r�l�r.
    public void Start()
    {
        // Ba�lang��ta herhangi bir i�lem yap�lm�yor.
    }

    // Update, her karede bir kez �a�r�l�r.
    public void Update()
    {
        // Her karede bir i�lem yap�lm�yor.
    }

    // Bu fonksiyon, bir nesne bu collider'a �arpt���nda �a�r�l�r.
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // �arp��an nesnenin ad�n� konsola yazd�r.
        Debug.Log("�arpan Nesnenin ad�: " + collision.gameObject.name);
    }

    // Bu fonksiyon, bir nesne bu collider ile olan �arp��madan ayr�ld���nda �a�r�l�r.
    public void OnCollisionExit2D(Collision2D collision)
    {
        // �arp��madan ayr�lan nesnenin ad�n� konsola yazd�r.
        Debug.Log("�arp��madan ayr�lan nesnenin ad�: " + collision.gameObject.name);
    }

    // Bu fonksiyon, bir nesne bu collider'�n "Is Trigger" �zelli�i etkinse
    // ve tetikleyici alana girdi�inde �a�r�l�r.
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Tetikleyen nesnenin ad�n� konsola yazd�r.
        Debug.Log("Tetikleyen Nesnenin ad�: " + collision.gameObject.name);
    }

    // Bu fonksiyon, bir nesne bu collider'�n "Is Trigger" �zelli�i etkinse
    // ve tetikleyici alandan ��kt���nda �a�r�l�r.
    public void OnTriggerExit2D(Collider2D collision)
    {
        // Tetiklemeden ayr�lan nesnenin ad�n� konsola yazd�r.
        Debug.Log("Tetiklemeden ayr�lan nesnenin ad�: " + collision.gameObject.name);
    }
}
