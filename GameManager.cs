using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;
        if (keyboard.enterKey.wasPressedThisFrame)
        {
            StartGame();
        }
        if (keyboard.rKey.wasPressedThisFrame)
        {
            RestartGame();
        }
        if (keyboard.escapeKey.wasPressedThisFrame)
        {
            QuitGame();
        }
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void QuitGame()
    {
        Application.Quit(); 
    }
}
