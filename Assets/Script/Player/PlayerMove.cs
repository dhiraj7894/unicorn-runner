using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float maxRight;
    [SerializeField] private float maxLeft;
    public float moveSpeed = 0.01f;


    public bool _isGrounded;


    public Transform LavaChecker;
    public Transform groundCheck;

    public LayerMask groundMask;

    private float turnInput, turnStrength = 50f, moveInput, timer;
    public float lavaCheckIncrement = 1.63f;
    //float gravity = -9.8f;
    float groundDistance = 0.5f;
    Vector3 _velocity;

    private void Start()
    {
        LavaChecker.localPosition = new Vector3(0.2446f, -0.489f, lavaCheckIncrement);
    }

    
    
    void Update()
    {
        moveForward();
        rightLeftBound();
        lavaChecker();

        turnInput = Input.GetAxis("Horizontal");
        moveInput = Input.GetAxis("Vertical");
        if (_isGrounded && !GameManager.gameManager.isJump && !GameManager.gameManager.isReached)
        {
            transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);
        }
        transform.Translate(Vector3.right * turnInput * moveSpeed * Time.deltaTime);
        groundChecker();
    }

    void lavaChecker()
    {
        if (lavaCheckIncrement <= 0)
        {
            lavaCheckIncrement = 0;
        }
        LavaChecker.localPosition = new Vector3(0.2446f, -0.489f, lavaCheckIncrement);
    }
    void rightLeftBound()
    {
        if(transform.position.x>= maxRight)
        {
            transform.position = new Vector3(maxRight, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= maxLeft)
        {
            transform.position = new Vector3(maxLeft, transform.position.y, transform.position.z);
        }
    }

    void groundChecker()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
    }

    void moveForward()
    {
        if (_isGrounded && !GameManager.gameManager.isJump)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (GameManager.gameManager.isJump && collision.gameObject.CompareTag("Ground") && !GameManager.gameManager.isReached)
        {
            transform.GetComponent<resetData>().resetAllData();
            GameManager.gameManager.isJump = false;
        }
        if (GameManager.gameManager.isReached)
        {
            transform.GetComponent<resetData>().resetAllData();
            GameManager.gameManager.isJump = false;
        }
    }
}
