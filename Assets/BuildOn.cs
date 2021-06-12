using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildOn : MonoBehaviour
{
    [SerializeField] string nameOfspike;
    public bool waiting = false;
    [SerializeField] GameObject spike1;[SerializeField] Collider Outcollider; [SerializeField] Collider Incollider;
    private void Start()
    {
        spike1 = FindInActiveObjectByName(nameOfspike);
        Outcollider = GameObject.Find("Outcollider").GetComponent<SphereCollider>();      
        Incollider = GameObject.Find("Player").GetComponent<SphereCollider>();
        StartCoroutine(waiter());
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")&& waiting ==true)
        {
                spike1.SetActive(true);
                Outcollider.enabled = true;
                Incollider.enabled = false;
                Destroy(this.gameObject);

            
            
        }
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        waiting = true;
    }
    GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].name == name)
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }
}
