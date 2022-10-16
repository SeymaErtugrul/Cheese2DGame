using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private float minX = -2.55f;
    private float maxX = 2.55f;

    void Update()
    {
        MovePlayer();
        
    }
    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 Currentposition = transform.position;
      
        if (h>0)
        {
            Currentposition.x += speed * Time.deltaTime;
        }
        else if (h<0)
        {
            Currentposition.x -= speed * Time.deltaTime;
        }
       

        if (Currentposition.x<minX)
        {
            Currentposition.x=minX;

        }

        if (Currentposition.x>maxX)
        {
                Currentposition.x=maxX;
        }
        transform.position = Currentposition;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag=="Bomb")
        {
            Time.timeScale = 0f;
        }
        
    }




}
