using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castOff : MonoBehaviour
{
    public static float Countdown;
    public Vector3 spikeTPos;public Vector3 spikeRPos;
    [SerializeField]GameObject spike1,spike2,spike3,spike4,spike5,spike6;
    [SerializeField] Rigidbody spikePre1,spikePre2,spikePre3,spikePre4, spikePre5, spikePre6;
    [SerializeField] Collider Incollider;[SerializeField] Collider OutCollider;
    [SerializeField] float force = 15f;
    Vector3[,] position = new Vector3[2,6];
    Rigidbody[] spikeprefab = new Rigidbody[6];
    GameObject[] spikes = new GameObject[6];
    void Start()
    {
        spikeprefab[0] = spikePre1 ; spikeprefab[1] = spikePre2; spikeprefab[2] = spikePre3; spikeprefab[3] = spikePre4; spikeprefab[4] = spikePre5; spikeprefab[5] = spikePre6;
        spikes = new GameObject[] { spike1, spike2, spike3, spike4, spike5, spike6 };
    }

    
    void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            position[i, 0] = spikes[i].transform.position;
            position[i, 1] = spikes[i].transform.eulerAngles;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            triggerCastOff();
        }
    }
    
    private void triggerCastOff()
    {
        spike1.gameObject.SetActive(false);spike2.gameObject.SetActive(false);
        for (int i = 0; i < 6; i++)
        {
            Rigidbody clone = (Rigidbody)Instantiate(spikeprefab[i], position[i,0],Quaternion.Euler(position[i,1]));
            clone.transform.LookAt(GameObject.Find("Player").transform);
            clone.AddExplosionForce(force, GameObject.Find("Player").transform.position, 5f);
        } 
        Incollider.enabled = true;
        OutCollider.enabled = false;
    }
}
