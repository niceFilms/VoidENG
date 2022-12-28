using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    float realspeed;
    public float gravity = -19.62f;
    public float jumpHeight = 3f;

    public float mindamage;
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float Stamina = 120f;
    public float x;
    public float y;
    public float z;

    Vector3 velocity;
    public bool isGrounded;

    public void ToggleMovement ()
    {
        this.enabled = !this.enabled;
    }

	// Update is called once per frame
	void Update()
    {

		isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift) && Stamina > 0 && x+z != 0)
            {
            z *= 2;
            x *= 2;
            Stamina -= 1*Time.deltaTime*20;
            if (Stamina <= 0) {
                Stamina = 0;
            }
            } 
if (Stamina < 100) {
        if (0 == x+z)
            {
                Stamina += 1*Time.deltaTime*20;
            } else 
                {
                    if (Input.GetKey(KeyCode.LeftShift))
                {
            
                    } else 
                    {
                        Stamina += 1*Time.deltaTime*10;
                    }
        }
}
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
	}
}
