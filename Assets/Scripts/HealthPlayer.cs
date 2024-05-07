using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public bool imAlive;

    private void Start()
    {
        health = maxHealth;
    }


    void RecieveDamage(int damage)
    {
        if (imAlive)
        {
            if(health > 0)
            {
                
                health--;
                FindObjectOfType<Vidas>().RemoveHearts(imAlive, health, maxHealth);
                if(health == 0)
                {
                    imAlive = false;
                    GameOver();
                }
            }
            if(health <= 0)
            {
                GameOver();
                imAlive = false;
                FindObjectOfType<Vidas>().RemoveHearts(imAlive, health, maxHealth);
            }
        }
    }

    void GameOver()
    {

    }
    private void OnTriggerEnter2D(Collider other)
    {
        //RecieveDamage(3444444);
    }
}
