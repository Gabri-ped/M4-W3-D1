using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenù : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene(1); 
    }
    public void LoadGame()
    {
        Debug.Log(" Il Bottone non è ancora implementato, ma lo sarà presto!");
    }
    public void Options()
    {
        SceneManager.LoadScene(3);
    }
    public void Credits()
    { 
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Debug.Log("Il gioco è stato chiuso!");
        Application.Quit();
    }
    
}
