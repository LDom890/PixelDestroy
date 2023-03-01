using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
   public void Restart()
   {
        SceneManager.LoadScene(1);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void pause()
    {
        

    }
    public void Exite()
    {
        Application.Quit();

    }
}
