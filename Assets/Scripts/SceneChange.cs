using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void Choose()
    {
        SceneManager.LoadScene("Choose");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
