using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootballz : MonoBehaviour
{
    public GameObject fireball;
    public GameObject flireball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            Instantiate(fireball, transform.position, transform.rotation);
        }

        if (Input.GetMouseButtonDown(0)) {
            Instantiate(flireball, transform.position, transform.rotation);
        }
    }

}
