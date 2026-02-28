using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public int speed;
    public GameObject player;
    public bool canSeePlayer;

    void Update()
    {
        if (!canSeePlayer)
        {
            if(Vector3.Distance(player.transform.position, transform.position) < 10f)
            {
                canSeePlayer = true;
            }
        }
        if (canSeePlayer)
        {
            Vector3 localPosition = player.transform.position - transform.position;
            localPosition = localPosition.normalized;
            transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
        }
        else{}
    }
}