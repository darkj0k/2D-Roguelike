using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Вход в игровую сцену");
        SceneManager.LoadScene("Main"); 
    }

    public void QuitGame()
    {
        Debug.Log("Выход из игры"); 
        Application.Quit();
    }
}
