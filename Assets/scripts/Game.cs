using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Text CountOfEv;
    public Text CountOfHi;
    public GameObject VeryBadAnd;
    public GameObject BadAnd;
    public GameObject AlmostGoodAnd;
    public GameObject GoodAnd;
    public GameObject VeryGoodAnd;
    public GameObject GreatAnd;

    private void Awake()
    {
        GlobalBase.CoutOfEvidence = 9;
        GlobalBase.CountOfHint = 5;
        GlobalBase.GamePoints = 0;
        GlobalBase.CardIsOpen = true;
    }

    void Update ()
    {
        CountOfEv.text = GlobalBase.CoutOfEvidence.ToString();
        CountOfHi.text = GlobalBase.CountOfHint.ToString();

        if (GlobalBase.CoutOfEvidence == 0 && GlobalBase.CardIsOpen == false)
        {
            EndOfGame();
        }
    }
    void EndOfGame()
    {
        if (GlobalBase.GamePoints < 0)
        {
            VeryBadAnd.SetActive(true);
        }
        if (GlobalBase.GamePoints >= 0 && GlobalBase.GamePoints <= 3)
        {
            BadAnd.SetActive(true);
        }
        if (GlobalBase.GamePoints >= 4 && GlobalBase.GamePoints <= 6)
        {
            AlmostGoodAnd.SetActive(true);
        }
        if (GlobalBase.GamePoints >= 7 && GlobalBase.GamePoints <= 8)
        {
            GoodAnd.SetActive(true);
        }
        if (GlobalBase.GamePoints >= 9 && GlobalBase.GamePoints <= 10)
        {
            VeryGoodAnd.SetActive(true);
        }
        if (GlobalBase.GamePoints >= 11)
        {
            GreatAnd.SetActive(true);
        }
    }
}
