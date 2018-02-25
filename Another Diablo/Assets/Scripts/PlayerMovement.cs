using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float speed;
    public bool stunned; // turning stunned true and false can be handled in the respective player controllers (and duration)

    void Start() {
        //currenthealth = health;
        rb2d = GetComponent<Rigidbody2D>();
        stunned = false;
    }

    // Update is called once per frame
    void Update() {
        if (!stunned) // not stunned
        {
            PlayerRotation();
            rb2d.transform.position += new Vector3(Input.GetAxis("Left Joystick Horizontal"), -Input.GetAxis("Left Joystick Vertical"), 0) * Time.deltaTime * speed;
        }
        // stunned
        // will not be able to move
    
    }

    void PlayerRotation()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = direction;
    }

    
}
