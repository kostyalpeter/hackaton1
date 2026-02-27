using UnityEngine;
using UnityEngine.InputSystem;

public class Clarinate : MonoBehaviour
{
    public GameObject Sound1;
    public GameObject Sound2;
    public GameObject Sound3;
    PlayerMovement playerMovement;
    public Vector3 offset1 = new Vector3(1f, 1f, 0f);
    public Vector3 offset2 = new Vector3(-1f, 1f, 0f);
    public static bool CanShoot = true;
    public static int Ammo = 5;
    public int RandomSound;

    void Start()
    {
        playerMovement = GetComponentInParent<PlayerMovement>();
    }

    public void Update()
    {
        RandomSound = Random.Range(1, 4);

        if (Keyboard.current.leftShiftKey.wasReleasedThisFrame)
        {
            float direction = Mathf.Sign(transform.localScale.x);
            if (Ammo > 0)
            {
                if (playerMovement.isFacingRight == false)
                {
                    Vector3 BulletPosition = transform.position + new Vector3(offset1.x * direction, offset1.y, 0f);
                    if (CanShoot)
                    {
                        Debug.Log("Asd");
                        if (RandomSound == 1)
                        {
                            Debug.Log("1");
                            Instantiate(Sound1, BulletPosition, Quaternion.identity);
                        }
                        if (RandomSound == 2)
                        {
                            Debug.Log("2");
                            Instantiate(Sound2, BulletPosition, Quaternion.identity);
                        }
                        if (RandomSound == 3)
                        {
                            Debug.Log("3");
                            Instantiate(Sound3, BulletPosition, Quaternion.identity);
                        }
                        Ammo -= 1;
                    }
                    else { }
                }
                else
                {
                    Vector3 BulletPosition = transform.position + new Vector3(offset2.x * direction, offset2.y, 0f);
                    if (CanShoot)
                    {
                        if (RandomSound == 1)
                        {
                            Debug.Log("1");
                            Instantiate(Sound1, BulletPosition, Quaternion.identity);
                        }
                        if (RandomSound == 2)
                        {
                            Debug.Log("2");
                            Instantiate(Sound2, BulletPosition, Quaternion.identity);
                        }
                        if (RandomSound == 3)
                        {
                            Debug.Log("3");
                            Instantiate(Sound3, BulletPosition, Quaternion.identity);
                        }
                        Ammo -= 1;
                    }
                }
            }
        }
    }
}