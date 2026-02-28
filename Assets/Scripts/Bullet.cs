using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public PlayerMovement playerMovement;
    public bool shootingRight;
    Damage damage;

    void Start()
    {
        if (playerMovement.isFacingRight)
        {
            shootingRight = true;
        }
        else
        {
            shootingRight = false;
        }
    }
    void Update()
    {
        if (shootingRight == true)
        {
            gameObject.transform.position += new Vector3(-1f, 0f, 0f) * Time.deltaTime * speed;
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
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
        else if (other.CompareTag("enemy"))
        {
            other.GetComponent<Damage>().Hit();
            Destroy(gameObject);
        }
    }
}

