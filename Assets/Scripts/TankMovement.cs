using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);
    }
}
