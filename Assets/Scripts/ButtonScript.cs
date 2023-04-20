using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Exit game");
        Application.Quit();
    }
    public void StartGame()
    {
        Debug.Log("Start game");
        SceneManager.LoadScene(1);
    }
}
