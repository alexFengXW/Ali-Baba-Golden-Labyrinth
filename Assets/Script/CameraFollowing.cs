using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera should follow (usually the player)
    public Vector3 offset;   // The offset distance between the camera and the target

    void Update()
    {
        // Set the camera's position to the target's position plus the offset
        transform.position = target.position + offset;
    }
}
