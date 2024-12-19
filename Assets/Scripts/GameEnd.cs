using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
