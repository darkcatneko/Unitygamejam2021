using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystleDes : MonoBehaviour
{
    
    void Start()
    {
        float vanish;
        vanish = Random.Range(1f, 2.5f);
        Instantiate(Resources.Load<GameObject>("FlamesParticleEffect"),transform.position,transform.rotation);
        Destroy(this.gameObject, vanish);
    }

    
    void Update()
    {
        
    }
}
