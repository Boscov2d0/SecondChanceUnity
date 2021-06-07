using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public GameObject Rules;
    public GameObject ButtonNext;
    public GameObject ButtonBack;
    public GameObject ChoosePanel;
    public GameObject[] RulesPage;
    public GameObject LicensePanel;
    int NomberOfPage = 0;

    [SerializeField]
    private LocalizationManager localizationManager;
    public GameObject[] ButtonLanguages;
    int NomberOfLanguage = 0;

    private void Start()
    {
        NomberOfLanguage = GlobalBase.NomberOfLanguage + 1;
        if (NomberOfLanguage >= ButtonLanguages.Length)
            NomberOfLanguage = 0;
        ButtonLanguages[NomberOfLanguage].SetActive(true);
    }

    //Main Panel
    public void ButtonOpenChoosePanel()
    {
        ChoosePanel.SetActive(true);
    }
    public void ButtonOpenRules()
    {
        Rules.SetActive(true);
    }
    public void ButtonExit()
    {
        Application.Quit();
    }
    public void ButtonChangeButtonLanguage()
    {
        ButtonLanguages[NomberOfLanguage].SetActive(false);
        NomberOfLanguage++;
        if (NomberOfLanguage >= ButtonLanguages.Length)
            NomberOfLanguage = 0;
        ButtonLanguages[NomberOfLanguage].SetActive(true);
    }
    public void ButtonEngLanguage()
    {
        localizationManager.CurrentLanguage = "en_US";
    }
    public void ButtonRusLanguage()
    {
        localizationManager.CurrentLanguage = "ru_RU";
    }
    public void ButtonChLanguage()
    {
        localizationManager.CurrentLanguage = "zh_ZH";
    }


    //MapPanel
    public void ButtonPlaySakura()
    {
        SceneManager.LoadScene("TheDaySakura");
    }
    public void ButtonPlayMusician()
    {
        SceneManager.LoadScene("DeathOfAMusician");
    }
    public void ButtonCloseMap()
    {
        ChoosePanel.SetActive(false);
    }

    //Rules
    public void ButtonCloseRules()
    {
        Rules.SetActive(false);
    }
    public void ButtonNextPage()
    {
        RulesPage[NomberOfPage].SetActive(false);
        NomberOfPage++;
        RulesPage[NomberOfPage].SetActive(true);
        if (NomberOfPage == 1)
            ButtonBack.SetActive(true);
        if (NomberOfPage == 12)
            ButtonNext.SetActive(false);
    }
    public void ButtonBackPage()
    {
        RulesPage[NomberOfPage].SetActive(false);
        NomberOfPage--;
        RulesPage[NomberOfPage].SetActive(true);
        if (NomberOfPage == 0)
            ButtonBack.SetActive(false);
        if (NomberOfPage == 11)
            ButtonNext.SetActive(true);
    }

    //License
    public void LicenseButtonOn()
    {
        LicensePanel.SetActive(true);
    }
    public void LicenseButtonOFF()
    {
        LicensePanel.SetActive(false);
    }
}
