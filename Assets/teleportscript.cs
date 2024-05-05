using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform destination;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position = destination.position;
    }
}
