using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempmech : MonoBehaviour
{
    public float warmth = 36.6f;
    public float maxwarmth = 200;
    public bool campfire = false;
    public float recover = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (campfire == true && warmth <maxwarmth) {
            warmth  += recover;
        }

        if (!campfire && warmth >=0){
            warmth -= Time.deltaTime;
        }
        if (warmth <= 0){
            transform.GetComponent<htlaeh>().TakeDamage(0.1f);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Fire"){
            campfire = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.transform.tag == "Fire"){
            campfire = false;
        }
    }
}
