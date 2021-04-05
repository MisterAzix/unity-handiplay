using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
     public void Load(){
        SceneManager.LoadScene("Menu");
    }
}
