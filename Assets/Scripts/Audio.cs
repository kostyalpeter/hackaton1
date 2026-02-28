using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource Src;
    public AudioClip Song1;
    public AudioClip Song2;
    public AudioClip Song3;
    public AudioClip Song4;
    public AudioClip Song5;
    public AudioClip Song6;
    public AudioClip Song7;
    public AudioClip Song8;
    public AudioClip Song9;
    public AudioClip Song10;
    public int Song = 1;
    void Start()
    {
        Src.PlayOneShot(Song1);
        Song = 1;
    }

    public void Presed()
    {
        if (Song == 1)
        {
            Src.Stop();
            Src.PlayOneShot(Song2);
            Song = 2;
        }
        else if (Song == 2)
        {
            Src.Stop();
            Src.PlayOneShot(Song3);
            Song = 3;
        }
        else if (Song == 3)
        {
            Src.Stop();
            Src.PlayOneShot(Song4);
            Song = 4;
        }
        else if (Song == 4)
        {
            Src.Stop();
            Src.PlayOneShot(Song5);
            Song = 5;
        }
        else if (Song == 5)
        {
            Src.Stop();
            Src.PlayOneShot(Song6);
            Song = 6;
        }
        else if (Song == 6)
        {
            Src.Stop();
            Src.PlayOneShot(Song7);
            Song = 7;
        }
        else if (Song == 7)
        {
            Src.Stop();
            Src.PlayOneShot(Song8);
            Song = 8;
        }
        else if (Song == 8)
        {
            Src.Stop();
            Src.PlayOneShot(Song9);
            Song = 9;
        }
        else if (Song == 9)
        {
            Src.Stop();
            Src.PlayOneShot(Song10);
            Song = 1;
        }
    }
}
