using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void ReturnToMenu()
    {
         SceneManager.LoadScene(0);
    }
    public void SaveOptions()
    {
        Debug.Log("Le opzioni sono state salvate!");
    }
}
