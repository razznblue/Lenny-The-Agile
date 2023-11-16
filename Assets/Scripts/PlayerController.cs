using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour {

    [SerializeField] float speed = 20f;

    private Rigidbody rb;

    void Start() {
      PrintInstructions();

      rb = GetComponent<Rigidbody>();
      if (rb == null) { 
        Debug.LogError("Rigidbody Not Found on Lenny!");
      }
    }

    void FixedUpdate() {
      MovePlayer();
    }

    void PrintInstructions() {
      Debug.Log("Hello Lenny!");
      Debug.Log("Move around and try to escape");
    }

    void MovePlayer() {
      float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
      float zVal = Input.GetAxis("Vertical") * Time.deltaTime * speed;

      Vector3 movement = new(xVal, 0, zVal);
      Vector3 velocity = movement * speed;

      rb.velocity = velocity;
      // rb.AddForce(movement * speed);
      // transform.Translate(xVal, 0, zVal);

      // Stop moving player if no input is given
      if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0) {
          rb.velocity = Vector3.zero;
          rb.angularVelocity = Vector3.zero;
      }
    }
}
