using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene(0);
    }
   public void Exit() 
    {
        Application.Quit();
    }
}
