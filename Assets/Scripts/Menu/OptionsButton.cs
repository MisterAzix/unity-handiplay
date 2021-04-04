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
 bool IsActive = false;

public class OptionsButton : MonoBehaviour
{

      void Update()
      { 
           if (Input.GetButton("Cancel"))
            {    
                  isActive = !isActive;
                  GameObject.SetActive(isActive);
            }
      }
}
