using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
 public void ExitGame()
 {
    Application.Quit();
 }
 public void StartGame()
 {
   SceneManager.LoadScene(1);
 }
}
