using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballmove : MonoBehaviour
{
    public float speed = 2f;
    void Start()
    {
        Destroy (gameObject, 120);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
