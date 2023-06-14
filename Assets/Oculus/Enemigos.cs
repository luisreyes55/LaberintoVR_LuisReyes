using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public Transform objetivo;
    public UnityEngine.AI.NavMeshAgent enemigo;
    public bool persigue;
    //public Animator controlEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(persigue){
            enemigo.destination = objetivo.position;
            //controlEnemigo.SetBool("correr",persigue);
        }
    }
}

