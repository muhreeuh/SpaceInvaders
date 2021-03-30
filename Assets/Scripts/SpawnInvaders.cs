﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{


    
    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    




    void Awake()
    {
        /*
         * "Pega" neste objecto, duplica e coloca-o "naquele" sítio
         */

        
            float x = xMin;
        for( int i = 1; i <= nInvasores; i++ )
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x, -0.5f, 0f);
            GameObject newInvaderA = Instantiate(invasorA, transform);
            newInvaderA.transform.position = new Vector3(x, 0f, 0f);
            GameObject newInvaderB = Instantiate(invasorB, transform);
            newInvaderB.transform.position = new Vector3(x, 0.5f, 0f);
            GameObject newInvaderBB = Instantiate(invasorB, transform);
            newInvaderBB.transform.position = new Vector3(x, 1f, 0f);
            GameObject newInvaderC = Instantiate(invasorC, transform);
            newInvaderC.transform.position = new Vector3(x, 1.5f, 0f);
            x += 1f;

            
            
        }
    }
}
