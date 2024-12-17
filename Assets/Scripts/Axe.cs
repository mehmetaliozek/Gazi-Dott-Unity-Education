using UnityEngine;

public class Axe : MonoBehaviour
{
    // Oyuncunun silah� ile d��mana zarar vermesini sa�layan bir script.

    public int damage; // D��mana verilecek hasar miktar�.
    public Animator animator; // Silah�n animasyonlar�n� kontrol eden Animator bile�eni.

    public void Update()
    {
        // E�er sol fare tu�una bas�l�rsa animasyonu ba�lat.
        if (Input.GetMouseButtonDown(0))
        {
            animator.enabled = true; // Animasyon devreye girer.
        }
        // E�er sol fare tu�u b�rak�l�rsa animasyonu durdur.
        else if (Input.GetMouseButtonUp(0))
        {
            animator.enabled = false; // Animasyon devreden ��kar.
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // �arp��ma sonucu temas edilen nesnenin etiketi "Enemy" ise ve animasyon oynuyorsa:
        if (collision.gameObject.CompareTag("Enemy") && animator.enabled)
        {
            // D��man�n can�n� belirtilen hasar miktar� kadar azalt.
            collision.gameObject.GetComponent<Goblin>().health -= damage;

            // E�er d��man�n can� s�f�r veya daha d���kse:
            if (collision.gameObject.GetComponent<Goblin>().health <= 0)
            {
                // D��man nesnesini yok et.
                Destroy(collision.gameObject);
            }
        }
    }

}
