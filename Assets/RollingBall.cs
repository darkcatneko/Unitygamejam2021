using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    private float xInput;
    private float yInput;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.drag = 10f;
        }
        else
        {
            rb.drag = 0f;
        }
    }
    
    private void FixedUpdate()
    {
        Move();
       
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        
        rb.AddForce(new Vector3(-xInput, 0f, -yInput) * moveSpeed);
        
        
    }
   
}
