using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;

public class characterController : MonoBehaviour
{
    const int movementSpeed = 6000;
    const int jumpForce = 16000;
    public int saltosMaximos = 1;
    public int saltosRestantes;
    SpriteRenderer spriteFlip;


    public LayerMask capaSuelo;

    // Start is called before the first frame update
    void Start()
    {
        saltosRestantes = saltosMaximos;
        spriteFlip = gameObject.GetComponent<SpriteRenderer>();
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
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D)) //Right movement
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * movementSpeed * Time.deltaTime);
            Return();
        }
        if (Input.GetKey(KeyCode.A)) //Left movement
        {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * movementSpeed * Time.deltaTime);
            Flip();
        }
        InTheFloor();
    }

    bool InTheFloor() //Function to reset the number of jumps
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(GetComponent<BoxCollider2D>().bounds.center, new Vector2(GetComponent<BoxCollider2D>().bounds.size.x, GetComponent<BoxCollider2D>().bounds.size.y), 0f, Vector2.down,
            0.8f, capaSuelo);
        return raycastHit.collider != null;
    }

    void Flip()
    {
        Vector3 scale = spriteFlip.transform.localScale = new Vector3(-1, 1, 1);
        transform.localScale = scale;
    }

    public void Return()
    {
        Vector3 scale = spriteFlip.transform.localScale = new Vector3(1, 1, 1);
        transform.localScale = scale;
    }
}


