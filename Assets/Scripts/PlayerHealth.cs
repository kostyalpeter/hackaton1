using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int health = 100;
    public Slider Hp;
    public AudioSource Src;
    public AudioClip Clip;
    PlayerMovement playerMovement;
    public bool isDead = false;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    public void Update()
    {
        Hp.value = health;

        if (!isDead && health <= 0)
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        if (isDead) return;

        health -= 5;

        if(health <= 0)
        {
            Die();
        }
        }
    public void TakeDamage2()
    {
        if (isDead) return;

        health -= 500;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        Gun.Ammo = 5;
        Src.PlayOneShot(Clip);
        playerMovement.Src.Stop();

        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        health = 100;
        SceneManager.LoadScene("Game");
    }
}