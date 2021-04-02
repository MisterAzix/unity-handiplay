using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ReturnButton : EventTrigger
{
   public override void OnPointerClick(PointerEventData data)
    {
          SceneManager.LoadScene("Menu");
    }
    
}
