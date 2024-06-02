using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public int amount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "Player"){
            other.GetComponent<htlaeh>().CollectCoin(amount);
            Destroy(gameObject);
        }
    }
}
