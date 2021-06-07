using UnityEngine;

public class OpenStoriesInfo : MonoBehaviour {

    public GameObject Sakura;
    public GameObject Musician;

    public void OpenSakuraInfo()
    {
        Sakura.SetActive(true);
    }
    public void CloseSakuraInfo()
    {
        Sakura.SetActive(false);
    }
    public void OpenMusicianInfo()
    {
        Musician.SetActive(true);
    }
    public void CloseMusicianInfo()
    {
        Musician.SetActive(false);
    }
}
