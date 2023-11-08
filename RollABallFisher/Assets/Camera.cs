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

public class Camera : MonoBehaviour
{
    //camera should follow player
    //Refrence to player
    public Transform player;
    public float yOffset;
    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y + yOffset, player.position.z);
        transform.LookAt(player.position);
    }
}
