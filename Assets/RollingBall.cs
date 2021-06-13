using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public static bool Fast = false;
    public float degreevalue = 1;
    public Rigidbody rb;
    public float moveSpeed = 1f;
    [SerializeField] float xInput;
    [SerializeField] float yInput;
    [SerializeField ]Vector2 ws = new Vector2();
    Vector2 ad = new Vector2();
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
        SpeedCheck();
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
        //ws = new Vector2 (Mathf.Sin(CamControl.xOffset), Mathf.Cos(CamControl.xOffset));
        //if (Mathf.Sin(CamControl.xOffset) != 0)
        //{
        //    xInput = xInput * Mathf.Cos(CamControl.xOffset);
        //}
        yInput = Input.GetAxis("Vertical");
        
        //if (Mathf.Cos(CamControl.xOffset) != 0)
        //{
        //    yInput = yInput * Mathf.Sin(CamControl.xOffset);
        //}
    }
    private void Move()
    {
        degreevalue = CamControl.xOffset * Mathf.Deg2Rad;
        rb.AddForce(new Vector3((-xInput*Mathf.Cos(-degreevalue)) +(-yInput*Mathf.Sin(degreevalue)), 0f, (-yInput* Mathf.Cos(degreevalue)) + (-xInput*Mathf.Sin(-degreevalue)))*moveSpeed);
        
        
    }
    public static Vector2 RadianToVector2(float radian)
    {
        return new Vector2(Mathf.Cos(radian + 90f), Mathf.Sin(radian + 90f));
    }
    
    public static Vector2 DegreeToVector2(float degree)
    {
        return RadianToVector2(degree * Mathf.Deg2Rad);
    }
    private void SpeedCheck()
    {
        if (rb.velocity.x>18f)
        {
            Fast = true;
            Invoke("Slowdown", 1f);
        }
    }

    private void Slowdown()
    {
        Fast = false;
    }
}
