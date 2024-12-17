using UnityEngine;

public class Axe : MonoBehaviour
{
    // Oyuncunun silahý ile düþmana zarar vermesini saðlayan bir script.

    public int damage; // Düþmana verilecek hasar miktarý.
    public Animator animator; // Silahýn animasyonlarýný kontrol eden Animator bileþeni.

    public void Update()
    {
        // Eðer sol fare tuþuna basýlýrsa animasyonu baþlat.
        if (Input.GetMouseButtonDown(0))
        {
            animator.enabled = true; // Animasyon devreye girer.
        }
        // Eðer sol fare tuþu býrakýlýrsa animasyonu durdur.
        else if (Input.GetMouseButtonUp(0))
        {
            animator.enabled = false; // Animasyon devreden çýkar.
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Çarpýþma sonucu temas edilen nesnenin etiketi "Enemy" ise ve animasyon oynuyorsa:
        if (collision.gameObject.CompareTag("Enemy") && animator.enabled)
        {
            // Düþmanýn canýný belirtilen hasar miktarý kadar azalt.
            collision.gameObject.GetComponent<Goblin>().health -= damage;

            // Eðer düþmanýn caný sýfýr veya daha düþükse:
            if (collision.gameObject.GetComponent<Goblin>().health <= 0)
            {
                // Düþman nesnesini yok et.
                Destroy(collision.gameObject);
            }
        }
    }

}
