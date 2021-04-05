using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject[] invasores;

    [SerializeField]
    GameObject[] invasoresIndestrutiveis;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;

    [SerializeField]
    float probabilidadeDeIndestrutivel = 0.15f;

    float speed = 0.5f;

    float direction = 1f;


    void Awake()
    {
       

        float y = yMin;
        

        for(int line = 0; line < invasores.Length; line++)
        {
           float x = xMin; 
            for (int i = 1; i <= nInvasores; i++)
                {
                    if(Random.value <= probabilidadeDeIndestrutivel)
                {
                    GameObject newInvader = Instantiate(invasoresIndestrutiveis[line], transform);
                    newInvader.transform.position = new Vector3(x, y, 0f);
                }
                    else
                {
                      GameObject newInvader = Instantiate(invasores[line], transform);
                      newInvader.transform.position = new Vector3(x, y, 0f); 
                }
                    x += xInc;
                }
        
                y += yInc;   
            }
 
         //* mais aleatoridade no disparo do inimigo (intervalo)
         //* movimentação dos inimigos - 
               
        }
    void Update()
    {
            transform.position += Time.deltaTime * speed * Vector3.right * direction;

            if (transform.position.x >= 0.5)
            {
                direction *= -1f;
            }
            if (transform.position.x <= -0.5)
            {
                direction *= -1f;
            }
        
    }

    }