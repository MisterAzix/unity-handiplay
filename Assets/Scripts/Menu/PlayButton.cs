using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PlayButton : MonoBehaviour {
    
//    public override void OnPointerClick(PointerEventData data)
//     {
//         SceneManager.LoadScene("Level_1");
//     }
 public void Load(){
      SceneManager.LoadScene("Level_1");
 }
void Update() {
     if (Input.GetButtonUp("Fire1"))
     {
        Load();
     }
 }
}