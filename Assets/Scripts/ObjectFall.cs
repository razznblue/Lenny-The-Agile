using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : MonoBehaviour
{

    [SerializeField] float timeDelay = 2f;
    
    private bool timeElapsed = false;
    
    private MeshRenderer meshRenderer;

    void Start() {
      if (TryGetComponent<MeshRenderer>(out meshRenderer)) {
        meshRenderer.enabled = false;
      } else {
        Debug.Log("Mesh Renderer Not Found");
      }
    }

    void Update() {
      EnableMeshRendererAfterDelay();
    }

    /* METHODS */
    void EnableMeshRendererAfterDelay() {
      if (Time.time >= timeDelay && !timeElapsed) {
        timeElapsed = true;
        meshRenderer.enabled = true;
        DropObject();
      }
    }

    void DropObject() {
      GetComponent<Rigidbody>().useGravity = true;
    }
}
