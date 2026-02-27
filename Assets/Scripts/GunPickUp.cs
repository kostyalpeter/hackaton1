using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    public GameObject GunItem;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GunItem.SetActive(true);
            Gun.CanShoot = true;
        }
    }
}
