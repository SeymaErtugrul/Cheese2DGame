using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CollectorScript : MonoBehaviour
{

   
    private int score;
    public TMP_Text scoreText;




    void IncreaseScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }
    

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            IncreaseScore();
            target.gameObject.SetActive(false); 
            // toplar sonsuza kadar dü?üp bellekte yer kaplamasin diye
            //düsen toplar? yok ediyoruz 
        }
    }
}
