using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystleBomb : MonoBehaviour
{
    [SerializeField] GameObject BombCrystle,CrystleWall;
    public Rigidbody RB;
    private void OnCollisionEnter(Collision collision)
    {
        RB = collision.gameObject.GetComponent<Rigidbody>();
        if (collision.gameObject.CompareTag("Player") && castOff.HardCheck == true && RollingBall.Fast==true)
        {
            BombCrystle.SetActive(true);
            CrystleWall.SetActive(false);            
        }
    }

}
