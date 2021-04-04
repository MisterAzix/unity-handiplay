using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easter : MonoBehaviour
{
    public bool EasterToggle;
        public void Toggle(){
        EasterToggle = !EasterToggle;
        Debug.Log(EasterToggle);
    }
}
