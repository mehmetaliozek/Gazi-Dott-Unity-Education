using UnityEngine;

public class SlowGround : MonoBehaviour
{
    // Önceki hýz bilgisini saklamak için kullanýlan deðiþken
    private float oldSpeed;

    // Ýki boyutlu bir çarpýþma algýlandýðýnda çalýþacak fonksiyon
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Çarpýþan nesnenin Player bileþeninden hýz bilgisini al ve sakla
        oldSpeed = collision.gameObject.GetComponent<Player>().speed;

        // Çarpýþan nesnenin hýzýný azalt
        collision.gameObject.GetComponent<Player>().speed = oldSpeed / 2.5f;
    }

    // Çarpýþma sona erdiðinde çalýþacak fonksiyon
    public void OnTriggerExit2D(Collider2D collision)
    {
        // Çarpýþan nesnenin hýzýný eski deðerine geri yükle
        collision.gameObject.GetComponent<Player>().speed = oldSpeed;
    }

}
