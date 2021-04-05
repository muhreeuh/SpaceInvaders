using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invaders : MonoBehaviour
{
    [SerializeField]
    GameObject fire;

 
     float cadencia;   

    float tempoQuePassou = 0f;

    float shots;

    void Update()
    {
     
        if (tag == "Destrutível")
        {
            cadencia = Random.Range(2f, 7f);
            tempoQuePassou += Time.deltaTime;
            if (tempoQuePassou >= cadencia)
            {
                Instantiate(fire, transform.position, transform.rotation);
                tempoQuePassou = 0f;
            }
        }
       
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(tag == "Destrutível")
        {
            if (collision.gameObject.tag == "FireFofo")
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
        else if(tag == "Indestrutível")
        {
            Destroy(collision.gameObject);
            shots = shots + 1f;

            if(shots >= 10f)
            {
                Destroy(gameObject);
            }
        }
    
    }

   
    
}
