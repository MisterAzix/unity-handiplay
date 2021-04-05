using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
     public void Load(){
        SceneManager.LoadScene("Menu");
    }
   void Update() {
     if (Input.GetKey("c") || Input.GetKey("b"))
     {
        Load();
     }
 }
}
