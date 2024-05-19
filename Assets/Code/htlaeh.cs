using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class htlaeh : MonoBehaviour
{
    public float health  = 10f;
  
    public void TakeDamage(float damage){
        health -= damage;
        print(health);
        if (health <= 0) {
            SceneManager.LoadScene(0);
        }
    }

}

