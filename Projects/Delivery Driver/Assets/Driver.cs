using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] public float streeSpeed = 1f;
    [SerializeField] public float moveSpeed = 25f;


    [SerializeField] public float boostSpeed = 40f;
    [SerializeField] public float slowSpeed = 15f;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float streeAmount = Input.GetAxis("Horizontal") * streeSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
         transform.Rotate(0 , 0, -streeAmount);
         transform.Translate(0, moveAmount,0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost"){
            moveSpeed = boostSpeed;
        }
    }
}
