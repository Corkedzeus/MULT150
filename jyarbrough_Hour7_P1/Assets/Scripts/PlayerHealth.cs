using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health;
        float poisonDamage;

        health = 1004f;
        poisonDamage = 125.5f;

        Debug.Log(health);
        health -= poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);
        health -= poisonDamage; // health = health - poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);
        health -= poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);
        health -= poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);
        health -= poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);
        health -= poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);
        health -= poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);
        health -= poisonDamage;

        Debug.Log("Damage taken " + poisonDamage);
        Debug.Log("health is " + health);

        Debug.Log("Player has been unalived!");






    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
