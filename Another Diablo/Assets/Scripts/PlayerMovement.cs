using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float speed;

    void Start() {
        //currenthealth = health;
        rb2d = GetComponent<Rigidbody2D>();
        //speed = 5f;
    }

    // Update is called once per frame
    void Update() {
        PlayerRotation();
        rb2d.transform.position += new Vector3(Input.GetAxis("Left Joystick Horizontal"), -Input.GetAxis("Left Joystick Vertical"), 0) * Time.deltaTime * speed;
    
    }

    void PlayerRotation()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = direction;
    }

    
}
