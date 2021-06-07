using UnityEngine;

public class MusicConstroller : MonoBehaviour {

    public GameObject music; //объект на котором аудиофайл
    public bool playMusic;

    void Update()
    {

        if (playMusic == true)
        {
            music.SetActive(true);
        }
        else
        {
            music.SetActive(false);
        }
    }
}
