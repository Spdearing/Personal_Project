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


    [Header("Bools")]
    [SerializeField] private bool withinRange;

    [SerializeField] private UIManager uiManager;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        walkSpeed = 5.0f;
        sprintSpeed = 10.0f;
        moveSpeed = walkSpeed;
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    private void Update()
    {
        HandleMovement();
        BasicMachineInteraction();
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

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MoneyMachine")
        {
            Debug.Log("Can press E");
            withinRange = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MoneyMachine")
        {
            withinRange = false;
        }
    }


    void BasicMachineInteraction()
    {
        if (Input.GetKeyDown(KeyCode.E) && withinRange)
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
