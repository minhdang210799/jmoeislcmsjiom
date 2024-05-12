using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOOOOST : MonoBehaviour
{
    public int sbeest = 20;
    public int junp = 7;
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        other.GetComponent<FirstPersonMovement>().runSpeed = sbeest;
        other.GetComponent<Jump>().jumpStrength = junp;
        
    }

    private void OnTriggerExit(Collider other) {
        other.GetComponent<FirstPersonMovement>().runSpeed = 5;
        other.GetComponent<Jump>().jumpStrength = 4;
    }


}
