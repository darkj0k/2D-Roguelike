using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("���� � ������� �����");
        SceneManager.LoadScene("Main"); 
    }

    public void QuitGame()
    {
        Debug.Log("����� �� ����"); 
        Application.Quit();
    }
}
