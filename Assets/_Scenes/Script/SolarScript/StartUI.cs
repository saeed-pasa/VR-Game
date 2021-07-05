using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }
     
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("yes");

    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("no");

    }
}
