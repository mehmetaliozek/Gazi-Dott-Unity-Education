using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Hedefin (target) pozisyonunu takip etmek için kullanýlan Transform nesnesi
    public Transform target;

    // Kameranýn hareket ederken ne kadar yumuþak olacaðýný belirleyen hýz faktörü
    public float smoothSpeed;

    // Çerçeve güncellemelerinin sonunda kameranýn hareketini iþlemek için LateUpdate kullanýlýyor
    public void LateUpdate()
    {
        // Hedefin pozisyonunu baz alarak istenen pozisyonu belirle
        Vector3 desiredPosition = target.position + Vector3.back; // Kamerayý hedefin arkasýnda konumlandýr

        // Kameranýn mevcut pozisyonu ile istenen pozisyon arasýnda yumuþak bir geçiþ saðla
        Vector3 smootPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Kameranýn pozisyonunu yumuþak geçiþ yapýlan pozisyona ayarla
        transform.position = smootPosition;
    }
}
