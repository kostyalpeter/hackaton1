using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Ketchup;
    public GameObject Mustard;
    public GameObject Clarinate;

    void Start()
    {
        if (CharacterChoose.Character == 1)
        {
            Player1.SetActive(true);
            Player2.SetActive(false);
            Player3.SetActive(false);
            Camera1.SetActive(true);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Ketchup.SetActive(true);
            Mustard.SetActive(false);
            Clarinate.SetActive(false);
        }
        else if (CharacterChoose.Character == 2)
        {
            Player1.SetActive(false);
            Player2.SetActive(true);
            Player3.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            Camera3.SetActive(false);
            Ketchup.SetActive(false);
            Mustard.SetActive(false);
            Clarinate.SetActive(true);
        }
        else if (CharacterChoose.Character == 3)
        {
            Player1.SetActive(false);
            Player2.SetActive(false);
            Player3.SetActive(true);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
            Ketchup.SetActive(false);
            Mustard.SetActive(true);
            Clarinate.SetActive(false);
        }
    }
}
