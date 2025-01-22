using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuController : MonoBehaviour
{
  public void PlayGame(){
    SceneManager.LoadScene("Gameplay");
  }
}
