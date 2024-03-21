using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowSettings()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void ShowMainMenu()
    {
        settingsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
