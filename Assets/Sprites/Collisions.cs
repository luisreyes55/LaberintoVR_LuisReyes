using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ganar")
        {
            Debug.Log("ganaste");
            SceneManager.LoadScene("Salida");
        }
        else if (other.gameObject.tag == "enemigo")
        {
            Debug.Log("perdiste");
            SceneManager.LoadScene("Perdiste");
        }
    }



}
