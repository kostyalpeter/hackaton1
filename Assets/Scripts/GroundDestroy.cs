using System.Collections;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{
    public float DestroyTime = 1f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(DestroyTime);
        Destroy(gameObject);
    }
}
