using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active : MonoBehaviour
{
        public GameObject go;
    public void SetActive(){
        //  GameObject.FindWithTag("Pause");
        go.GetComponent<OptionsButton>().activeFalse();
    }
}
