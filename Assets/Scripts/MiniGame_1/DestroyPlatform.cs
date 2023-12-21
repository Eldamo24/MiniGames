using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    [SerializeField]
    private GameObject fallPlatform;

    void Start()
    {
            
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject platform = Instantiate(fallPlatform, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(platform, 5f);
            

        }
    }
}
