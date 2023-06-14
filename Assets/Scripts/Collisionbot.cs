using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionbot : MonoBehaviour
{
    public GameObject objetoADestruir;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bala")
        {
            Debug.Log("muerto");
            Destruir();
        }
    }
        

    public void Destruir()
    {
        Destroy(objetoADestruir);
    }

}
