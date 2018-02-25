using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb2d;
    /////////////Player Variables/////////////
    public float speed;

    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        PlayerRotation();
        if (Input.GetKey(KeyCode.W))
            rb2d.transform.position += Vector3.up * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            rb2d.transform.position += Vector3.left * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            rb2d.transform.position += Vector3.down * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            rb2d.transform.position += Vector3.right * speed * Time.deltaTime;
    }

    void PlayerRotation()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = direction;
    }
}
