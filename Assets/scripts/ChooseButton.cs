using UnityEngine;
using UnityEngine.UI;

public class ChooseButton : MonoBehaviour {

    int CardPoint;
    GameObject Result;
    public GameObject Buttons;

    void Start()
    {
        CardPoint = gameObject.GetComponent<ChooseButtonsInfo>().MisticNumber;
        Result = gameObject.GetComponent<ChooseButtonsInfo>().Result;
    }

    public void Button()
    {
        GlobalBase.GamePoints += CardPoint;
        GlobalBase.AnswerWasChosen = true;
        Color c = gameObject.GetComponent<Graphic>().color;
        //c.r = 0;c.g = 0;c.b = 255;
        c.a = 0.8f;
        gameObject.GetComponent<Graphic>().color = c;
        Buttons.SetActive(false);
        Result.SetActive(true);
    }
}
