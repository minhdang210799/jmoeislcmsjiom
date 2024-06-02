using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class htlaeh : MonoBehaviour
{
    public float health  = 10f;
    public float coins;
    public TextMeshProUGUI cointext;
    public Slider healthslider;
  
    public void TakeDamage(float damage){
        health -= damage;
        healthslider.value = health;
        print(health);
        if (health <= 0) {
            SceneManager.LoadScene(0);
        }
    }

    private void Start() {
        cointext.text = coins.ToString();
        healthslider.maxValue = health;
        healthslider.value = health;
    }

    public void CollectCoin(float amount){
        coins += amount;
        cointext.text = coins.ToString();

    }


}



