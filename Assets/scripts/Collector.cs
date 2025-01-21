using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Collision detected with: {collision.name}");

        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Enemy destroyed!");
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("Not an enemy!");
        }
    }
}
