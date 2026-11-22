using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with enemy");
            SceneManager.LoadScene("Battle");
        }
    }
}
