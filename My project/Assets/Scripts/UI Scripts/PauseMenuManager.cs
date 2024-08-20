using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;

    private void Start()
    {
        // Desactiva los menús al inicio
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
    }

    private void Update()
    {
        // Escucha la tecla "P" para pausar/despausar el juego
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        // Activa o desactiva el menú de pausa
        pauseMenuUI.SetActive(!pauseMenuUI.activeSelf);

        // Pausa o despausa el tiempo en el juego
        Time.timeScale = pauseMenuUI.activeSelf ? 0f : 1f;
    }

    public void ReturnToMainMenu()
    {
        // Carga la escena del menú principal
        SceneManager.LoadScene("MainMenu"); // Cambia "MainMenu" al nombre de tu escena del menú principal
    }

    public void OpenOptionsMenu()
    {
        // Activa el menú de opciones y oculta el menú de pausa
        optionsMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        // Cierra la aplicación (solo funciona en build)
        Application.Quit();
    }
}
