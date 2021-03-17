using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PLAYER : MonoBehaviour
{

    [SerializeField]private float maxRight;
    [SerializeField]private float maxLeft;

    public float moveSpeed = 0.01f;
    public float righLeftSpeed = 10f;


    public bool _isGrounded;

    public LayerMask groundMask;

    float groundDistance = 0.5f;
    Vector3 _velocity;
    [SerializeField]private Transform LavaChecker;
    [SerializeField]private Transform groundCheck;
    

    
    void Update()
    {
        if(!_GAMEMANAGER.gameManager.addForce)
            movement();

        if (_GAMEMANAGER.gameManager.isPlayerWantToGoCentre)
        {
            moveToCentre();
        }
    }

    float x;
    public void movement()
    {
        

        if (!_GAMEMANAGER.gameManager.isPlayerInCentre)
        {
            x = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * x * moveSpeed * Time.deltaTime);
        }
        //moveSpeed = 10;

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        groundChecker();
        rightLeftBound();
    }

    void groundChecker()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
    }
    void rightLeftBound()
    {
        if (transform.position.x >= maxRight)
        {
            transform.position = new Vector3(maxRight, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= maxLeft)
        {
            transform.position = new Vector3(maxLeft, transform.position.y, transform.position.z);
        }
    }
    void moveToCentre()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-0.28f, transform.position.y, transform.position.z), 0.02f);
    }
}
