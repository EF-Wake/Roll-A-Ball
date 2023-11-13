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

public class NewBehaviourScript : MonoBehaviour
{
    int score = 0;
    int lives = 3;
    [SerializeField] float speed = 5.0f;
    Rigidbody rb;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        movement = movement.normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}
