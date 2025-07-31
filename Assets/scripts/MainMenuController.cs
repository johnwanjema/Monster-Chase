using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuController : MonoBehaviour
{
  public void PlayGame(){

    // Returns a string
    int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

    Debug.Log( "Index :" + selectedCharacter);

    GameManager.instance.CharIndex = selectedCharacter;

    SceneManager.LoadScene("Gameplay");
  }
}
