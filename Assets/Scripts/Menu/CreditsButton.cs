using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CreditsButton : EventTrigger
{
   public override void OnPointerClick(PointerEventData data)
    {
          SceneManager.LoadScene("Credits");
    }
    
}
