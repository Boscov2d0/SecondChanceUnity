using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour {

    public GameObject StoryPanel;
    public GameObject DecisionPanel;

    public void ButtonVolumeOn()
    {
        if (!GlobalBase.CardIsOpen)
            gameObject.GetComponent<MusicConstroller>().playMusic = true;
    }
    public void ButtonVolumeOff()
    {
        if (!GlobalBase.CardIsOpen)
            gameObject.GetComponent<MusicConstroller>().playMusic = false;
    }
    public void ButtonMainMenu()
    {
        if (!GlobalBase.CardIsOpen)
            SceneManager.LoadScene("MainMenu");
    }
    public void ButtonReadStory()
    {
        StoryPanel.SetActive(true);
    }
    public void ButtonReadDecision()
    {
        DecisionPanel.SetActive(true);
    }
    public void ButtonPlayAgainSakura()
    {
        SceneManager.LoadScene("TheDaySakura");
    }
    public void ButtonPlayAgainMusician()
    {
        SceneManager.LoadScene("DeathOfAMusician");
    }
}
