using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{

//Rigidbody  rigibody;

    void Start()
    {
     // rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

  MovementPlayer();
    }

    void MovementPlayer()
    {
float movX = Input.GetAxis("Horizontal");

float movY = Input.GetAxis("Vertical");

transform.Translate(new Vector3(movX *Time.deltaTime , 0, movY* Time.deltaTime));

//Rotation

if (Input.GetKey(KeyCode.Q))
{
    transform.Rotate(0,-5,0);
}

if (Input.GetKey(KeyCode.E))
{
    transform.Rotate(0,5,0);
}

    }
 private void OnTriggerEnter(Collider other) {
    Debug.Log("el objeto triggereo"); 

    }

}
