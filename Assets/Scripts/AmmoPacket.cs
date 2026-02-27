using UnityEngine;

public class AmmoPacket : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Gun.Ammo += 10;
            Destroy(gameObject);
        }
    }
}
