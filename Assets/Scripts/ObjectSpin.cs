using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpin : MonoBehaviour
{

    [SerializeField] float speed = 50f;

    void Update() {
      float movement = Time.deltaTime * speed;
      transform.Rotate(0, movement, 0);
    }
}
