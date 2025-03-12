using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotación

    void Update()
    {
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0); // Rotar solo en el eje Y
    }
}
