using UnityEngine;
using UnityEngine.EventSystems;


public class OptionsButton : MonoBehaviour
{
      public GameObject pause;
     public bool activeSelf;

void Update()
{
      if (Input.GetButtonUp("Cancel") || Input.GetKey("b"))
      {   
        activeSelf = !activeSelf;
      }  
      //Debug.Log(activeSelf);
      if (activeSelf)
      {
        pause.SetActive(true);
        Time.timeScale = 0f; 
      }
      if (activeSelf==false)
      {
        pause.SetActive(false);
        Time.timeScale = 1f; 
      }
}
// public void Button(){
//       activeSelf = false; 
// }
public void activeFalse(){
      activeSelf = false;
}
// public void Pause(){
//       if (Time.timeScale == 1f)
//             {
//                   Time.timeScale = 0f;          
//             }
//             else if (Time.timeScale == 0f)
//             {
//                   Time.timeScale = 1f;   
//             }
// }
// public void Toggle(){
//       if (activeSelf==false)
//       {
//             activeSelf = true;
//       }
      // Pause();
// }
}