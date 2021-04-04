using UnityEngine;
using UnityEngine.EventSystems;
// using UnityEngine.SceneManagement;

// public class OptionsButton : EventTrigger
// {
//    public override void OnPointerClick(PointerEventData data)
//     {
//           SceneManager.LoadScene("Options");
//     }
    
// }

public class OptionsButton : MonoBehaviour
{
      public GameObject pause;
      public bool activeSelf;
void Update()
{
      if (Input.GetButtonUp("Cancel"))
      {    
            pause.SetActive(!activeSelf);
            activeSelf = !activeSelf;
            Pause();
      }  
}
public void Pause(){
      if (Time.timeScale == 1f)
            {
            Time.timeScale = 0f;          
            }else
            {
                  Time.timeScale = 1f;   
            }
            Debug.Log(Time.timeScale);
}
}