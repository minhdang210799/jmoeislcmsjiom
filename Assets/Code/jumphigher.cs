using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumphigher : MonoBehaviour
{
    // Start is called before the first frame update
    public int JumpStrength = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider nhynikuh)
    {
        nhynikuh.gameObject.GetComponent<Jump>().jumpStrength = JumpStrength;
    }
    private void OnTriggerExit(Collider scnirsm)
    {
        scnirsm.gameObject.GetComponent<Jump>().jumpStrength = 4;
    }
}

