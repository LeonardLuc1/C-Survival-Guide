using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesScript : MonoBehaviour
{
    //create a variable to store your name
    //age
    //speed
    //health
    //score
    //check if all keys were collected
    //ammo

    public string myName = "Leonard";
    public int age = 34;
    public float speed = 3.5f;
    public int health = 100;
    public int score = 0;
    public bool haskeys;
    public int ammo = 50;



    void Start()
    {
        Debug.Log("Hi, my name is " + myName);
        Debug.Log("My age is " + age);
        Debug.Log("Im traveling at " + speed);
        Debug.Log("My health is at " + health);
        Debug.Log("Total score is " + score);
        Debug.Log("Ammo left " + ammo);
        Debug.Log("Do we have the keys? " + haskeys);
        Debug.Log("Game Over");
       

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
