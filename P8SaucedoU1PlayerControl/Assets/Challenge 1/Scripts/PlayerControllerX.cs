using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float turnspeed = 55.0f;
    public float plane;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.left * Time.deltaTime * turnspeed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);


        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
