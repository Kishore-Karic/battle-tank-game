using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TankMovement : MonoBehaviour {

	[SerializeField] private float movementSpeed, rotateSpeed;
	private float movement, rotation;

	private Rigidbody rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movement = CrossPlatformInputManager.GetAxis("Vertical");
        rotation = CrossPlatformInputManager.GetAxis("Horizontal");

        Movement(movement, rotation);
    }

    private void Movement(float movement, float rotation)
    {
        if (movement != 0) 
        {
            rb.velocity = transform.forward  * movement * movementSpeed;
        }

        if (rotation != 0)
        {
            Vector3 vector = new Vector3(0f, rotation * rotateSpeed, 0f);
            Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }
}
