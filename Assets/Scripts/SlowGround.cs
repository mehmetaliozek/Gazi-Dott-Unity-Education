using UnityEngine;

public class SlowGround : MonoBehaviour
{
    private float oldSpeed;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        oldSpeed = collision.gameObject.GetComponent<Player>().speed;
        collision.gameObject.GetComponent<Player>().speed = oldSpeed / 2.5f;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Player>().speed = oldSpeed;
    }
}
