using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Player"){
            SceneManager.LoadScene(0);}
        
    }
}
