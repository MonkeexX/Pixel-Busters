using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float movementSpeed = 57.0f;
    public float jumpForce = 35.0f;
    public int saltosMaximos = 2;
    public int saltosRestantes;
    public LayerMask capaSuelo;

    // Start is called before the first frame update
    void Start()
    {
        saltosRestantes = saltosMaximos;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (InTheFloor()) //Reset of jumps when the character touches the floor
        {
            saltosRestantes = saltosMaximos;      
        }
        if (Input.GetKeyDown(KeyCode.Space) && saltosRestantes > 0) //Jump input
        {
            saltosRestantes = saltosRestantes - 1;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D)) //Right movement
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A)) //Left movement
        {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * movementSpeed);
        }
        InTheFloor();
    }

    bool InTheFloor() //Function to reset the number of jumps
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(GetComponent<BoxCollider2D>().bounds.center, new Vector2(GetComponent<BoxCollider2D>().bounds.size.x, GetComponent<BoxCollider2D>().bounds.size.y), 0f, Vector2.down,
            0.2f, capaSuelo);
        return raycastHit.collider != null;
    }
}
