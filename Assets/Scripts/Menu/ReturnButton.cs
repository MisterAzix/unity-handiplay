using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public void Load(){
SceneManager.LoadScene("Menu");
}
    void Update() {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
