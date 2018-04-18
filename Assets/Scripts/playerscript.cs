using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class playerscript : MonoBehaviour {
 
    public float movementspeed, movementspeedmodifier, currenthealth, maxhealth = 100, currentarmor = 0, maxarmor = 100;
    public bool moving = false;

    private Rigidbody2D rb2d;
    private CharacterController charcont;
 
    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        charcont = GetComponent<CharacterController>();
 
        currenthealth = maxhealth;
        maxarmor = currentarmor;
 
    }
 
    // Update is called once per frame
    void Update ()
    {
        facemouse();
    }
 
    //deals with rigidbodys only so movement basically
    void FixedUpdate()
    {
		moving = false;

        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddForce(Vector2.up * movementspeed * movementspeedmodifier);
            moving = true;
        }
 
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddForce(Vector2.down * movementspeed * movementspeedmodifier);
            moving = true;
        }
 
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * movementspeed * movementspeedmodifier);
            moving = true;
        }
 
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * movementspeed * movementspeedmodifier);
            moving = true;
        }
		

		if(!moving) rb2d.drag = 5;
 
    }
 
    void facemouse()
    {
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
 
        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );
        transform.up = direction;
    }
}