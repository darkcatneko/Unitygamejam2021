using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystleBomb : MonoBehaviour
{
    [SerializeField] GameObject BombCrystle,CrystleWall;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player") && castOff.HardCheck == true)
        {
            BombCrystle.SetActive(true);
            CrystleWall.SetActive(false);            
        }
    }

}
