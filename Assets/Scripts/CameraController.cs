using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Hedefin (target) pozisyonunu takip etmek i�in kullan�lan Transform nesnesi
    public Transform target;

    // Kameran�n hareket ederken ne kadar yumu�ak olaca��n� belirleyen h�z fakt�r�
    public float smoothSpeed;

    // �er�eve g�ncellemelerinin sonunda kameran�n hareketini i�lemek i�in LateUpdate kullan�l�yor
    public void LateUpdate()
    {
        // Hedefin pozisyonunu baz alarak istenen pozisyonu belirle
        Vector3 desiredPosition = target.position + Vector3.back; // Kameray� hedefin arkas�nda konumland�r

        // Kameran�n mevcut pozisyonu ile istenen pozisyon aras�nda yumu�ak bir ge�i� sa�la
        Vector3 smootPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Kameran�n pozisyonunu yumu�ak ge�i� yap�lan pozisyona ayarla
        transform.position = smootPosition;
    }
}
