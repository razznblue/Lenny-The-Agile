using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
  // Update color of object when the player collides with it
  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.CompareTag("Player")) {
      GetComponent<MeshRenderer>().material.color = Color.cyan;
      gameObject.tag = "Hit";
    }   
  }
}
