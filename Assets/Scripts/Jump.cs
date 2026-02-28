using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    public GameObject Button1;
    public void JumpSet()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        if (PlayerMovement.Jump == true)
        {
            PlayerMovement.Jump = false;
            Button1.SetActive(false);
        }
        else
        {
            PlayerMovement.Jump = true;
            Button1.SetActive(true);
        }
    }
}

