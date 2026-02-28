using System.Collections;
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
            if (Gun.Ammo > 0)
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
                            GameObject Sound1Clone = Instantiate(Sound1, BulletPosition, Quaternion.identity);
                            StartCoroutine(Wait1());
                            IEnumerator Wait1()
                            {
                                yield return new WaitForSeconds(7f);
                                Destroy(Sound1Clone);
                            }
                        }
                        if (RandomSound == 2)
                        {
                            Debug.Log("2");
                            GameObject Sound2Clone = Instantiate(Sound2, BulletPosition, Quaternion.identity);
                            StartCoroutine(Wait2());
                            IEnumerator Wait2()
                            {
                                yield return new WaitForSeconds(7f);
                                Destroy(Sound2Clone);
                            }
                        }
                        if (RandomSound == 3)
                        {
                            Debug.Log("3");
                            GameObject Sound3Clone = Instantiate(Sound3, BulletPosition, Quaternion.identity);
                            StartCoroutine(Wait3());
                            IEnumerator Wait3()
                            {
                                yield return new WaitForSeconds(7f);
                                Destroy(Sound3Clone);
                            }
                        }
                        Gun.Ammo -= 1;
                    }
                }
                else if (playerMovement.isFacingRight == true)
                {
                    Vector3 BulletPosition = transform.position + new Vector3(offset2.x * direction, offset2.y, 0f);
                    if (CanShoot)
                    {
                        if (RandomSound == 1)
                        {
                            Debug.Log("1");
                            GameObject Sound1Clone = Instantiate(Sound1, BulletPosition, Quaternion.identity);
                            StartCoroutine(Wait4());
                            IEnumerator Wait4()
                            {
                                yield return new WaitForSeconds(7f);
                                Destroy(Sound1Clone);
                            }

                        }
                        if (RandomSound == 2)
                        {
                            Debug.Log("2");
                            GameObject Sound2Clone = Instantiate(Sound2, BulletPosition, Quaternion.identity);
                            StartCoroutine(Wait5());
                            IEnumerator Wait5()
                            {
                                yield return new WaitForSeconds(7f);
                                Destroy(Sound2Clone);
                            }
                        }
                        if (RandomSound == 3)
                        {
                            Debug.Log("3");
                            GameObject Sound3Clone = Instantiate(Sound3, BulletPosition, Quaternion.identity);
                            StartCoroutine(Wait6());
                            IEnumerator Wait6()
                            {
                                yield return new WaitForSeconds(7f);
                                Destroy(Sound3Clone);
                            }
                        }
                        Gun.Ammo -= 1;
                    }
                }
            }
        }

    }

}