using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        // Yatay eksendeki (Horizontal) input de�eri al�n�r. �rne�in: A/D tu�lar� veya ok tu�lar�
        float horizontal = Input.GetAxis("Horizontal");

        // Dikey eksendeki (Vertical) input de�eri al�n�r. �rne�in: W/S tu�lar� veya ok tu�lar�
        float vertical = Input.GetAxis("Vertical");

        // Yatay ve dikey input de�erleri ile bir hareket vekt�r� olu�turulur.
        // Z ekseni 0 olarak ayarlan�r ��nk� bu hareket sadece 2D d�zlemde ger�ekle�ecektir.
        // Vector3(x, y, z) format�nda bir vekt�r olu�turuluyor.
        Vector3 vector = new Vector3(horizontal, vertical, 0) * 5 * Time.deltaTime;

        // Karakteri (veya nesneyi) hareket ettirir. 
        // "vector" hareket y�n�n� ve h�z�n� i�eriyor. Time.deltaTime, hareketin frame-rate ba��ms�z olmas�n� sa�lar.
        transform.Translate(vector);
    }
}
