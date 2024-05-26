using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    public float Speed;
    public GameObject flireball;
    // Start is called before the first frame updat
    // Update is called once per frame
    void Update()
    { 
        transform.position += transform.forward * Speed * Time.deltaTime;
        Destroy(flireball, 10);


    }
    void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "enemy"){
            Destroy(other.gameObject);
        }
    }
}
