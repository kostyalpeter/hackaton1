using UnityEngine;

public class Border : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Border"))
        {
          GetComponent<PlayerHealth>().TakeDamage2();
        }
    }
}
