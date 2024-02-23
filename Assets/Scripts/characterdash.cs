using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class characterdash : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private characterController player;
    private float baseGravity;
    private int direction;

    [SerializeField] private float dashingTime = 0.3f;
    [SerializeField] private float dashForce = 1.0f;
    [SerializeField] private float dashCooldown = 2.5f;
    private bool isDashing;
    private bool canDash;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        player = GetComponent<characterController>();
        baseGravity = rb2D.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.D))
        {
            direction = 1;
        }
       else if(Input.GetKeyDown(KeyCode.A))
        {
            direction = -1;
        }
       if(Input.GetKeyDown(KeyCode.LeftShift))
        StartCoroutine(Dash());
    }

    private IEnumerator Dash()
    {
        isDashing = true;
        canDash = false;
        rb2D.gravityScale = 0f;
        rb2D.velocity = new Vector2(direction * dashForce, 0f);
        yield return new WaitForSeconds(dashingTime);
        isDashing = false;
        rb2D.gravityScale = baseGravity;
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }
   
}


