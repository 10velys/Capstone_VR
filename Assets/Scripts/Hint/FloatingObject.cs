using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float rotateSpeed = 50f;
    public float floatAmplitude = 0.1f; // Tinggi naik-turun
    public float floatFrequency = 1f;   // Kecepatan naik-turun

    Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        // Putar object
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        // Gerakan naik turun (Sinus wave)
        Vector3 tempPos = startPos;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * floatFrequency) * floatAmplitude;
        transform.localPosition = tempPos;
    }
}