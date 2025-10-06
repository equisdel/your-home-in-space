using UnityEngine;

public class LunarDayCycle : MonoBehaviour
{
    // velocidad de rotación del sol
    public float rotationSpeed = 20.0f;

    void Update()
    {
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
