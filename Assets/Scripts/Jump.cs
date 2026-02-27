using System.Collections;
using UnityEngine;

public class Jump : MonoBehaviour
{

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
        }
        else
        {
            PlayerMovement.Jump = true  ;
        }
    }
}

