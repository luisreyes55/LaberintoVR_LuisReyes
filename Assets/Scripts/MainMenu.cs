using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject objectToActivate;
    public void ActivateObject()
    {
        // Activar el GameObject
        objectToActivate.SetActive(true);
    }
    public void DisableObject()
    {
        // Desactivar el GameObject
        objectToActivate.SetActive(false);
    }
    public void EscenaJuego()
    {
        SceneManager.LoadScene("laberinto");
    }
    public void EscenaMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void EscenaFinal()
    {
        SceneManager.LoadScene("Salida");
    }
}
