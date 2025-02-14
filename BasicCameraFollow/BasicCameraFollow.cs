using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public Vector3 offset;   // Offset from the player
    public float smoothSpeed = 0.125f; // Smoothing factor

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset; // Calculate desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smooth transition
        transform.position = smoothedPosition; // Update camera position
    }
}
