using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void OpenOptions()
    {
        SceneManager.LoadScene("MainMenu"); // Aseg�rate de que el nombre coincida con el de tu escena de men� de opciones
    }
}
