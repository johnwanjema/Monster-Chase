using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
