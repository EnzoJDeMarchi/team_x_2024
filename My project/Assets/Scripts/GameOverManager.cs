using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void Retry()
    {
        // Carga la escena del juego para reintentar
        SceneManager.LoadScene("Level_1"); // Cambia "GameScene" por el nombre de tu escena del juego
    }

    public void MainMenu()
    {
        // Carga la escena del men� principal
        SceneManager.LoadScene("MainMenu"); // Cambia "MainMenu" por el nombre de tu escena del men� principal
    }

    public void QuitGame()
    {
        // Cierra la aplicaci�n (solo funciona en build)
        Application.Quit();
    }
}
