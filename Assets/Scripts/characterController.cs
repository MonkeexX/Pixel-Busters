using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
<<<<<<< HEAD
    public float movementSpeed = 5.0f;
    public float jumpForce = 5.0f;

=======
>>>>>>> c608511c705669deb6f45bbb2da221b1007f4ded
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movementSpeed, 0);
        }
=======
        
>>>>>>> c608511c705669deb6f45bbb2da221b1007f4ded
    }
}
