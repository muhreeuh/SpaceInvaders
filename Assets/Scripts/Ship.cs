﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]
    GameObject fire;

    [SerializeField]
    Transform nozzle;

    [SerializeField]
    float velocidade = 5f;

        float vidas = 3f;

    float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        minX = Camera.main.ViewportToWorldPoint(Vector2.zero).x + 0.5f;
        maxX = Camera.main.ViewportToWorldPoint(Vector2.one).x - 0.5f;

    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, nozzle.position, nozzle.rotation);
        }

        MoveShip();
     }
    
         void MoveShip()
        {
            float hMov = Input.GetAxis("Horizontal");
            transform.position += hMov * velocidade * Vector3.right * Time.deltaTime;

            Vector3 position = transform.position;
            position.x = Mathf.Clamp(position.x, minX, maxX);
            transform.position = position;
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
  
            if (collision.gameObject.tag == "FireEnemy")
            {
                vidas = vidas - 1f;
                Destroy(collision.gameObject);
            }
            if(vidas <= 0f)
            {
                Destroy(gameObject);
            }
        }
}
