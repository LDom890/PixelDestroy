using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;





    public void Restart()
   {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void Exite()
    {
        Application.Quit();

    }
    public void Play()
    {
        SceneManager.LoadScene(1);

    }
    public void Credits()
    {
        SceneManager.LoadScene(1);

    }
    public void Store()
    {
        SceneManager.LoadScene(1);

    }
    public void NextLevel(int indice)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(indice+1);

    }
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);

    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);

    }
}
