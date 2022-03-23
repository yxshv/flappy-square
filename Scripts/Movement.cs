using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float jumpForce = 20f;
    public float movementSpeed = 200f;
    bool jump = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
        }

        if (transform.position.y >= 5.30f || transform.position.y <= -5.30f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, rb.velocity.y);
        if (jump) {
            rb.velocity = new Vector2(0, jumpForce * Time.fixedDeltaTime);
            jump = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "obs") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }      
    }
}
