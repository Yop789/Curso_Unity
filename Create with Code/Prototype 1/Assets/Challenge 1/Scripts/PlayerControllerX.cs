using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // obtener la entrada vertical del usuario
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // mover el avión hacia adelante a una velocidad constante
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        // inclinar el avión hacia arriba/abajo basado en las teclas de flecha arriba/abajo
        // y girar el avión hacia la izquierda/derecha basado en las teclas de flecha izquierda/derecha
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * horizontalInput);
    }
}
