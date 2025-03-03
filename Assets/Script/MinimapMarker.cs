using UnityEngine;
using UnityEngine.UI;

public class MinimapMarker : MonoBehaviour
{
    public Transform player; // Assign the player's transform in the inspector
    private RectTransform myRectTransform;

    void Start()
    {
        myRectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Convert world position to local position on the minimap
        Vector2 minimapPosition = new Vector2(player.position.x, player.position.z);
        myRectTransform.anchoredPosition = minimapPosition;
    }
}
