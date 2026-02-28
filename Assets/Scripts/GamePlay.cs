using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    void Start()
    {
        if (CharacterChoose.Character == 1)
        {
            Player1.SetActive(true);
            Player1.SetActive(false);
            Player1.SetActive(false);
        }
        else if (CharacterChoose.Character == 2)
        {
            Player1.SetActive(false);
            Player1.SetActive(true);
            Player1.SetActive(false);
        }
        else if (CharacterChoose.Character == 3)
        {
            Player1.SetActive(false);
            Player1.SetActive(false);
            Player1.SetActive(true);
        }
    }
}
