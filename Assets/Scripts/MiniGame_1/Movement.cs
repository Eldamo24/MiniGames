using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 5f;
    private float jumpForce = 3f;
    public int lifes = 5;
    [SerializeField]
    private bool onFloor;
    [SerializeField]
    private GameObject gameUI;
    [SerializeField]
    private GameObject pauseUI;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(-vertical, 0f, horizontal);
        rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            onFloor = false;
            rb.velocity += jumpForce * Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameUI.SetActive(false);
            pauseUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "GamePlatform")
        {
            onFloor = true;
        }
    }

}
