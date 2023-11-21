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
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject scoresign;
    private TMP_Text message;
    int score = 0;
    public int lives = 3;
    [SerializeField] float speed = 5.0f;
    Rigidbody rb;
    Vector3 movement;
    private AudioSource capsule;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void setscore(float scoreTotal)
    {
        float currentscore = float.Parse(scoresign.GetComponent<TMP_Text>().text);
        float newscore = currentscore + scoreTotal;
        scoresign.GetComponent<TMP_Text>().text = newscore.ToString("F0");
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
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Pickup Object"))
        {
            Destroy(collision.gameObject);
            score = score + 1;
            capsule = GetComponent<AudioSource>();
            capsule.Play();
        }
    }
}
