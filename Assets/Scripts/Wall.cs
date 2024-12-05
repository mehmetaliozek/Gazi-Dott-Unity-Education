using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start, MonoBehaviour ilk oluþturulduðunda ve Update'den önce bir kez çaðrýlýr.
    public void Start()
    {
        // Baþlangýçta herhangi bir iþlem yapýlmýyor.
    }

    // Update, her karede bir kez çaðrýlýr.
    public void Update()
    {
        // Her karede bir iþlem yapýlmýyor.
    }

    // Bu fonksiyon, bir nesne bu collider'a çarptýðýnda çaðrýlýr.
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpýþan nesnenin adýný konsola yazdýr.
        Debug.Log("Çarpan Nesnenin adý: " + collision.gameObject.name);
    }

    // Bu fonksiyon, bir nesne bu collider ile olan çarpýþmadan ayrýldýðýnda çaðrýlýr.
    public void OnCollisionExit2D(Collision2D collision)
    {
        // Çarpýþmadan ayrýlan nesnenin adýný konsola yazdýr.
        Debug.Log("Çarpýþmadan ayrýlan nesnenin adý: " + collision.gameObject.name);
    }

    // Bu fonksiyon, bir nesne bu collider'ýn "Is Trigger" özelliði etkinse
    // ve tetikleyici alana girdiðinde çaðrýlýr.
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Tetikleyen nesnenin adýný konsola yazdýr.
        Debug.Log("Tetikleyen Nesnenin adý: " + collision.gameObject.name);
    }

    // Bu fonksiyon, bir nesne bu collider'ýn "Is Trigger" özelliði etkinse
    // ve tetikleyici alandan çýktýðýnda çaðrýlýr.
    public void OnTriggerExit2D(Collider2D collision)
    {
        // Tetiklemeden ayrýlan nesnenin adýný konsola yazdýr.
        Debug.Log("Tetiklemeden ayrýlan nesnenin adý: " + collision.gameObject.name);
    }
}
