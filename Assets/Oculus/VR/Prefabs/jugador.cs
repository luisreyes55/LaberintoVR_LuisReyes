using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public Transform posArma;
    public GameObject bala;
    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.M))
        {
            var balas = Instantiate(bala, posArma.position, Quaternion.identity);
            var rb = balas.GetComponent<Rigidbody>();
            rb.AddForce(posArma.forward * fuerza, ForceMode.Impulse);
        }


    }
}
