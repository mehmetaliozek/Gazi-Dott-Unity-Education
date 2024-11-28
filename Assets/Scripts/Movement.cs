using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        // Yatay eksendeki (Horizontal) input deðeri alýnýr. Örneðin: A/D tuþlarý veya ok tuþlarý
        float horizontal = Input.GetAxis("Horizontal");

        // Dikey eksendeki (Vertical) input deðeri alýnýr. Örneðin: W/S tuþlarý veya ok tuþlarý
        float vertical = Input.GetAxis("Vertical");

        // Yatay ve dikey input deðerleri ile bir hareket vektörü oluþturulur.
        // Z ekseni 0 olarak ayarlanýr çünkü bu hareket sadece 2D düzlemde gerçekleþecektir.
        // Vector3(x, y, z) formatýnda bir vektör oluþturuluyor.
        Vector3 vector = new Vector3(horizontal, vertical, 0) * 5 * Time.deltaTime;

        // Karakteri (veya nesneyi) hareket ettirir. 
        // "vector" hareket yönünü ve hýzýný içeriyor. Time.deltaTime, hareketin frame-rate baðýmsýz olmasýný saðlar.
        transform.Translate(vector);
    }
}
