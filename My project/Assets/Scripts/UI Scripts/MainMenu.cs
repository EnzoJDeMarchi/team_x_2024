using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("OptionsMenu"); // Asegúrate de que el nombre coincida con el de tu escena de menú de opciones
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
