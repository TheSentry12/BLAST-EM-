using UnityEngine;
using UnityEngine.SceneManagement;


public class Game_over : MonoBehaviour
{
 public void RestartButton()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
