using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    public float Speed;
    // Start is called 
    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, 10);
    }
    void Update()
    { 
        transform.position += transform.forward * Speed * Time.deltaTime;
        


    }
    void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "enemy"){
            Destroy(other.gameObject);
        }
    }
}
