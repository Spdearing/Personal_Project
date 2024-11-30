using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float walkSpeed;
    [SerializeField] private float sprintSpeed;
    private float moveSpeed;

    [Header("RigidBody")]
    private Rigidbody rb;

    [SerializeField] private int playerPoints;



    [SerializeField] private PlayerCollisions collisions;
    [SerializeField] private UIManager uiManager;


    private void Start()
    {
        SetUp();
    }

    private void Update()
    {
        HandleMovement();
        BasicMachineInteraction();
    }

    void SetUp()
    {
        rb = GetComponent<Rigidbody>();
        walkSpeed = 5.0f;
        sprintSpeed = 10.0f;
        moveSpeed = walkSpeed;
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        collisions = GetComponent<PlayerCollisions>();
    }

    private void HandleMovement()
    {
        // Get input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized;

        // Adjust speed based on sprint input
        moveSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed;

        // Move the player using Rigidbody
        Vector3 move = movement * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }


    void BasicMachineInteraction()
    {
        if (Input.GetKeyDown(KeyCode.E) && collisions.ReturnWithinRange())
        {
            playerPoints += 1;
            uiManager.UpdatePlayerPoints(playerPoints);
        }
    }

    public int ReturnPlayerPoints()
    {
        return this.playerPoints;
    }
}
