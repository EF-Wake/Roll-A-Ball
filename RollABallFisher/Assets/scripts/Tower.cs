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

public class Tower : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",0 , 3.0f);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        GameObject Instance = Instantiate(projectile, transform.position, Quaternion.identity);
        Instance.transform.parent = gameObject.transform;
    }
}
