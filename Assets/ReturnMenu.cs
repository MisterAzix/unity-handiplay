using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    public GameObject go;
    public void Invert(){
        go.GetComponent<OptionsMenu>().Invert();
    }
}
