using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class QuitButton : EventTrigger
{
   public override void OnPointerClick(PointerEventData data)
    {
        Application.Quit();
    }
    
}
