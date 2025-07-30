using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuController : MonoBehaviour
{
  public void PlayGame(){

    // Returns a string
    int selectedPlayer = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

    Debug.Log( "Index :" + selectedPlayer);

    SceneManager.LoadScene("Gameplay");
  }
}
