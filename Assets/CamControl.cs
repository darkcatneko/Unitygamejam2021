using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Rigidbody Player;
    public static float xOffset, yOffset, zOffset;
    [SerializeField] float degree;
    public float RotationSpeed = 15f;
    
    void Start()
    {
        
    }
    //void LateUpdate()
    //{
    //    CamControler();
    //}
    void Update()
    {
        
        transform.position = Player.position ;
        if (true)
        {
            if (Input.GetMouseButton(0))
            {
                xOffset += Input.GetAxis("Mouse X") * RotationSpeed;
                degree = xOffset;
                yOffset += Input.GetAxis("Mouse Y") * RotationSpeed;
                if (yOffset<-35f)
                {
                yOffset = -35f;
                }
                //else if(yOffset>60)
                //{
                //yOffset = 60f;
                //}
               
            }
            
            transform.rotation = Quaternion.Euler(yOffset, xOffset, 0f);
        }
    }
    //void CamControler()
    //{
    //    xOffset += Input.GetAxis("Mouse X") * RotationSpeed;
    //    yOffset -= Input.GetAxis("Mouse Y") * RotationSpeed;
    //    yOffset = Mathf.Clamp(yOffset, -35, 60);
    //    transform.LookAt(Player.transform);
    //    target.transform.rotation = Quaternion.Euler(yOffset, xOffset, 0);
    //}
}
