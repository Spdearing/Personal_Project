using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [Header("Target Settings")]
    [SerializeField] private Transform playerTransform;

    [Header("Camera Offset")]
    [SerializeField] private Vector3 offset;

    [Header("Smoothness")]
    [SerializeField] private float followSpeed = 10f;

    private void Awake()
    {
        
    }

    private void Start()
    {
        offset = new Vector3(0, 9, -0.5f);
        playerTransform = GameObject.Find("Player").transform;
    }

    private void LateUpdate()
    {
        if (playerTransform == null)
        {
            Debug.LogWarning("Player Transform is not assigned in the CameraFollow script!");
            return;
        }

        // Target position based on player's position and offset
        Vector3 targetPosition = playerTransform.position + offset;

        // Smoothly move the camera to the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Optionally, align the camera to look straight down
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}