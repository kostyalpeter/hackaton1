using UnityEngine;
using System.Collections;

public class SoundShot : MonoBehaviour
{
    public float speed;
    public PlayerMovement playerMovement;
    Damage damage;

    void Update()
    {
        if (playerMovement.isFacingRight)
        {
            gameObject.transform.position += new Vector3(-1f, 0f, 0f) * Time.deltaTime * speed;
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            gameObject.transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ShootWall"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("enemy"))
        {
            other.GetComponent<Damage>().Hit2();
        }
    }
}