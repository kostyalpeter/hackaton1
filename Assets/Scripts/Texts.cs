using UnityEngine;
using TMPro;

public class Texts : MonoBehaviour
{
    public TMP_Text AmmoText;

    void Update()
    {
        AmmoText.text = "Ammo:" + Gun.Ammo.ToString();
    }
}
