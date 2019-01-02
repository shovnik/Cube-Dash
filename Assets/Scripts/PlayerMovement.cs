using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float pushForce;
    public float inputForce;

	void FixedUpdate ()
    {
        rb.AddForce(0, 0, pushForce * Time.deltaTime, ForceMode.VelocityChange);

        if(Input.GetKey("right"))
        {
            rb.AddForce(inputForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-inputForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("r") || rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
