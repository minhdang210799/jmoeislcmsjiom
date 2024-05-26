using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject player;

    public float health = 2.5f;
    public float speed = 3f;
    public float damage = 2;
    // Start is called before the first frame update

    void Start(){
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        chase();
        stares();
    }
    void chase(){
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    void stares(){
        transform.LookAt(player.transform.position);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "Player"){
            other.transform.GetComponent<htlaeh>().TakeDamage(damage);
        }
    }
}
