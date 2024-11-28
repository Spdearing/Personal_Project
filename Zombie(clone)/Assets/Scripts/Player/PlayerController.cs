using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float walkSpeed;
    [SerializeField] private float sprintSpeed;
    [SerializeField] private float moveSpeed;

    [Header("RigidBody")]
    private Rigidbody rb;

    [SerializeField] private UIManager uIManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 5.0f;
        walkSpeed = 5.0f;
        sprintSpeed = 10.0f;
        uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized;

        moveSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed;

        Vector3 move = movement * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MoneyMachine")
        {
            uIManager.SetWarningText("Press E To Make Money");
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "MoneyMachine")
        {
            uIManager.SetWarningText("");
        }
    }
}
