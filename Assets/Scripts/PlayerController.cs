using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerAccel = 12f;

    CharacterController controller;
    //Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();
    }

    void handleMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = x * transform.right * playerAccel + z * transform.forward * playerAccel;
        //velocity = velocity + new Vector3(x * playerAccel, 0, z * playerAccel) * Time.deltaTime;
        controller.Move(movement * Time.deltaTime);
    }

    
}
