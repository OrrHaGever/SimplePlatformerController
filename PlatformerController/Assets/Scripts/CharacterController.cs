using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour
{
	public Collider2D circleColider;

	// Movment Parameters
	// Set the values from the Unity editor. test it and tune accordingly for best results.
	public float movementSpeed;
	public float jumpForce; // To get the jumping right, tune the jump force along with the rigidbody mass, drag and gravity scale.
	private float moveInput;
	
	// Checks
	public LayerMask whatIsGround; // This variable will let you choose what layers are the ground, simply choose a layer from the editor.
	public Transform groundCheck; // This variable will be the transform checking for the ground. Create an empty game object as a child of the player and position it on the tip of the player's feet, then set it as the groundCheck from the editor.
	public float checkRadius; // radious of the ground checker, set it to a value that will detect the ground only when the player's feet are touching the ground. This is important for smooth jumping.
	private bool isGrounded;
	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>(); // Assign the rigidbody component to the variable.
	}
    private void Update()
    {
		if (Input.GetKey(KeyCode.Space) && isGrounded == true) // Handle jumping when Space Bar is pressed only if player is touching the ground. 
		{
			rb.velocity = Vector2.up * jumpForce; // Assign Y axis velocity.
		}
	}
    void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); // Use the transform of the groundCheck to check if player is touching the ground.
		moveInput = Input.GetAxis("Horizontal"); // Get the X axis value from keyboard input
		rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y); // Assign X axis velocity and direction to the player's rigidbody.
	}
	
}