using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds.")]
    public float dayDuration = 120f; // Default to 2 minutes per day

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed based on the duration of the day
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around the X-axis based on the calculated speed and time elapsed
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
