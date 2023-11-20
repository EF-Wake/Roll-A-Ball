//////////////////////////////////////////////////////
// Assignment/Lab/Project: Roll A Ball
//Name: Ethan Fisher
//Section: 2023FA.SGD.113.2102
//Instructor: Ven Lewis
// Date: 11/8/2023
//////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject ball;
    

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
