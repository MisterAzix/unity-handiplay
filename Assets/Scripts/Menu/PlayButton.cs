using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PlayButton : EventTrigger
{
   public override void OnPointerClick(PointerEventData data)
    {
        SceneManager.LoadScene("Level_1");
    }
    
}