using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    public LayerMask obstacleLayer;
    public float minimumDistanceToObstacle = 0.5f;  

    private Vector3 currentVelocity;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, smoothSpeed);
        transform.position = AdjustCameraPosition(target.position, smoothedPosition);
        transform.LookAt(target);
    }

    Vector3 AdjustCameraPosition(Vector3 targetPosition, Vector3 desiredPosition)
    {
        RaycastHit hit;
        Vector3 direction = desiredPosition - targetPosition;
        float distance = offset.magnitude;

       
        if (Physics.Raycast(targetPosition, direction.normalized, out hit, distance, obstacleLayer))
        {
            // If an obstacle is hit, adjust the camera position to stay a fixed distance from the obstacle
            return hit.point - direction.normalized * minimumDistanceToObstacle;
        }

        return desiredPosition;  // No adjustment needed
    }
}
