using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isPaused;
    [SerializeField] KeyCode _escapeKey;
    private AudioSource _audioSource;
    private Canvas _pauseMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _pauseMenuCanvas = GetComponent<Canvas>();
        _pauseMenuCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
    void PauseGame()
    {
        if (_isPaused)
        {
            Time.timeScale = 0.0f;
            _audioSource.Pause();

        }
        else
        {

            Time.timeScale = 1.0f;
            _audioSource.UnPause();
        }


        if (Input.GetKeyDown(_escapeKey))
        {
            _isPaused = !_isPaused;
            if (_isPaused)
            {
                _pauseMenuCanvas.enabled = true;
            }
            else
            {
                _pauseMenuCanvas.enabled = false;
            }

        }

    }
    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
    public void ResumeGame()
    {
        _isPaused = false;
        _pauseMenuCanvas.enabled = false;
        Time.timeScale = 1.0f;
        _audioSource.UnPause();
    }
}
