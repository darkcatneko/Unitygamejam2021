using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castOff : MonoBehaviour
{
    public Vector3 spikeTPos;public Vector3 spikeRPos;
    [SerializeField] GameObject spike;[SerializeField] Rigidbody spikePre;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spikeTPos = spike.transform.position;
        spikeRPos = spike.transform.position;
        if (Input.GetKeyDown(KeyCode.R))
        {
            triggerCastOff();
        }
    }
    private void triggerCastOff()
    {
        spike.gameObject.SetActive(false);
        Rigidbody clone = (Rigidbody)Instantiate(spikePre, spikeTPos,Quaternion.Euler(spikeRPos));
        clone.AddForce(15f, 0f, 0f);
    }
}
