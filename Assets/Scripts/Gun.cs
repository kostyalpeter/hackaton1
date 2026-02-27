using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    PlayerMovement playerMovement;
    public Vector3 offset1 = new Vector3(1f, 1f, 0f);
    public Vector3 offset2 = new Vector3(-1f, 1f, 0f);
    public static bool CanShoot;
    public static int Ammo = 5;

    void Start()
    {
        playerMovement = GetComponentInParent<PlayerMovement>();

    }

    public void Update()
    {
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
                        Instantiate(Bullet, BulletPosition, quaternion.identity);
                        Ammo -= 1;
                    }
                    else { }
                }
                else
                {
                    Vector3 BulletPosition = transform.position + new Vector3(offset2.x * direction, offset2.y, 0f);
                    if (CanShoot)
                    {
                        Instantiate(Bullet, BulletPosition, quaternion.identity);
                        Ammo -= 1;
                    }
                }
            }
        }
    }
}