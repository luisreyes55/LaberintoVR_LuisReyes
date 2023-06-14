using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 2f;  // Velocidad de movimiento de la c�mara

    void Update()
    {
        // Obtener la entrada del teclado
        float horizontalInput = 0f;
        float verticalInput = 0f;

        // Verificar las teclas presionadas
        if (Input.GetKey(KeyCode.W))
            verticalInput = 1f;
        if (Input.GetKey(KeyCode.S))
            verticalInput = -1f;
        if (Input.GetKey(KeyCode.A))
            horizontalInput = -1f;
        if (Input.GetKey(KeyCode.D))
            horizontalInput = 1f;

        // Calcular el desplazamiento de la c�mara
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Normalizar el vector de movimiento para evitar movimientos diagonales m�s r�pidos
        movement.Normalize();

        // Mover la c�mara en funci�n de la entrada del teclado
        transform.Translate(movement * movementSpeed * Time.deltaTime);
    }
}
