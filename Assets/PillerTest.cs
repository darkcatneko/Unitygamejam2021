using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerTest : MonoBehaviour
{
    [SerializeField] GameObject bridge;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            bridge.SetActive(true);
        }
    }
}
