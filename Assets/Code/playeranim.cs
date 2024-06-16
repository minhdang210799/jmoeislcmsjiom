using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranim : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
            anim.SetBool("walk", true);

        }
        else{
            anim.SetBool("walk", false);
        }

        if(Input.GetKey(KeyCode.Space)){
            anim.SetBool("jump", true);


        }



    }

    private void OnCollisionEnter(Collision other){
        anim.SetBool("jump", false);

    }

}
