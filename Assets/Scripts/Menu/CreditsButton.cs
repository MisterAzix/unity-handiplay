using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
//    public override void OnPointerClick(PointerEventData data)
//     {
//           SceneManager.LoadScene("Credits");
//     }
     public void Load(){
      SceneManager.LoadScene("Credits");
 }
void Update() {
     if (Input.GetKey("c"))
     {
         Load();
     }
 }
}

