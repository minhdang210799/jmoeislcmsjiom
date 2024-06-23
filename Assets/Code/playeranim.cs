using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranim : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
        //     // anim.SetBool("walk", true);
        //     anim.SetFloat("y", anim.GetFloat("y") + Time.deltaTime);
        // }
        // else{
        //     // anim.SetBool("walk", false);
        //     anim.SetFloat("y", anim.GetFloat("y") - Time.deltaTime);
        // }

        anim.SetFloat("x", Input.GetAxis("Horizontal"), 0.1f, Time.deltaTime);
        anim.SetFloat("y", Input.GetAxis("Vertical"), 0.1f, Time.deltaTime);

        if(Input.GetKey(KeyCode.Space)){
            anim.SetBool("jump", true);
        }
    }

    private void OnCollisionEnter(Collision other){
        anim.SetBool("jump", false);

    }

}
