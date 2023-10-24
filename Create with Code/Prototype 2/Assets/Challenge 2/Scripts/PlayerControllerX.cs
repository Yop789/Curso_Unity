using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawnTime;
    private float spawnCooldown = 2.5f; // Tiempo en segundos que el jugador debe esperar antes de generar otro perro

    // Update is called once per frame
    void Update()
    {
        // Si la tecla de espacio es presionada y ha pasado el tiempo de enfriamiento
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime > spawnCooldown)
        {
            // Generar un nuevo perro
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Actualizar el tiempo de la última generación
            lastSpawnTime = Time.time;
        }
    }
}
