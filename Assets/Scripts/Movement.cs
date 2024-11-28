using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log("Horizontal: "+horizontal+"/Vertical: "+vertical);

        Vector3 vector = new Vector3(horizontal, vertical, 0) * 5 * Time.deltaTime;
        transform.Translate(vector);    

    }
}
