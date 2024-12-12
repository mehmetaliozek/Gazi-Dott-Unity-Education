using UnityEngine;

public class SlowGround : MonoBehaviour
{
    // �nceki h�z bilgisini saklamak i�in kullan�lan de�i�ken
    private float oldSpeed;

    // �ki boyutlu bir �arp��ma alg�land���nda �al��acak fonksiyon
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // �arp��an nesnenin Player bile�eninden h�z bilgisini al ve sakla
        oldSpeed = collision.gameObject.GetComponent<Player>().speed;

        // �arp��an nesnenin h�z�n� azalt
        collision.gameObject.GetComponent<Player>().speed = oldSpeed / 2.5f;
    }

    // �arp��ma sona erdi�inde �al��acak fonksiyon
    public void OnTriggerExit2D(Collider2D collision)
    {
        // �arp��an nesnenin h�z�n� eski de�erine geri y�kle
        collision.gameObject.GetComponent<Player>().speed = oldSpeed;
    }

}
