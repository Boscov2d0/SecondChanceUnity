using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour {

    public GameObject Hint;
    bool ShowHint = false;

    void Update () {
        if (ShowHint)
        {
            if (Hint.GetComponent<Text>().color != new Color(255.0f, 0.0f, 0.0f, 1f))
                Hint.GetComponent<Text>().color += new Color(255.0f, 0.0f, 0.0f, 0.01f);
            else
                ShowHint = false;
        }
    }
    public void ButtonOpenHint()
    {
        if (GlobalBase.CountOfHint > 0)
        {
            Hint.SetActive(true);
            ShowHint = true;
            --GlobalBase.CountOfHint;
            gameObject.GetComponent<Button>().enabled = false;
        }
    }
}
