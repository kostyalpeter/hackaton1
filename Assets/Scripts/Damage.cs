using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int Health = 100;
    public int asdas;
    public bool isDamaging;
    public bool CanHit;
    public AudioSource Src;
    public AudioClip Clip;
    public GameObject Secret;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Damages();
            StartCoroutine(Wait());
            CanHit = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        CanHit = false;
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        if (CanHit)
        {
            Damages();
            StartCoroutine(Wait());
        }
    }

    public void Hit()
    {
        Health -= 50;
        if (Health <= 0)
        {
            Destroy(gameObject);
            {
                Secret.SetActive(false);
            }
            Secret.SetActive(false);
            Src.PlayOneShot(Clip);
        }
    }
    public void Hit2()
    {
        Health -= 20;
        if (Health <= 0)
        {
            Destroy(gameObject);
            {
                Secret.SetActive(false);
            }
            Src.PlayOneShot(Clip);
        }
    }


    public void Damages()
    {
        isDamaging = true;
        PlayerHealth.health -= asdas;
        Debug.Log("Damage");
        isDamaging = false;
    }
}