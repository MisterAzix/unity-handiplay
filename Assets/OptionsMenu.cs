using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{     
    public GameObject pause;
    public GameObject audio;
    public bool isActive;
    void Update(){
        if (Input.GetButtonUp("Cancel"))
        {   
       Invert();
        }  
      if (isActive)
      {
        pause.SetActive(true);
        audio.SetActive(false);

      }
      if (isActive==false)
      {
        pause.SetActive(false);
        audio.SetActive(true);
      }

    }
    public void Invert(){
 isActive = !isActive;
    }
}
