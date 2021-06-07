using UnityEngine;

public class CardButton : MonoBehaviour {

    [SerializeField] bool StoryCardFirstOpen;
    [SerializeField]bool FirstGameCard;
    [SerializeField] bool IsSpecioalCard;

    public void OpenCardButton()
    {
        if (GlobalBase.CardIsOpen == false)
        {
            if (StoryCardFirstOpen)
            {
                gameObject.GetComponent<CardAnim>().enabled = true;
                StoryCardFirstOpen = false;
                --GlobalBase.CoutOfEvidence;
                GlobalBase.AnswerWasChosen = false;
            }
            else
            {
                gameObject.GetComponent<CardAnim>().Story.SetActive(true);
            }
            GlobalBase.CardIsOpen = true;        
        }
    }
    public void CloseStoryButton()
    {
        if (IsSpecioalCard)
        {
            GlobalBase.AnswerWasChosen = true;
            if (FirstGameCard)
            {
                GameObject.Find("MainFone").GetComponent<MusicConstroller>().playMusic = true;
                FirstGameCard = false;
            }
        }
        if (GlobalBase.AnswerWasChosen)
        {
            gameObject.GetComponent<CardAnim>().Story.SetActive(false);
            GlobalBase.CardIsOpen = false;
        }
    }
}
