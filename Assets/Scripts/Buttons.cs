using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void AboutMenu()
    {
        SceneManager.LoadScene("AboutMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
