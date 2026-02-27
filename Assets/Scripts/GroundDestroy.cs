using System.Collections;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
