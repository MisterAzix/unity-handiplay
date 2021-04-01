using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OptionsButton : EventTrigger
{
   public override void OnPointerClick(PointerEventData data)
    {
        Debug.Log("Options called.");
    }
    
}
