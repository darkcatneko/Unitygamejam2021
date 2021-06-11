using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject Player;
    public float xOffset, yOffset, zOffset;
    
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(Player.transform.position);
    }
}
