using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBuildings : MonoBehaviour{

    Component[] childRenderers;

    private void Awake() {
        childRenderers = GetComponentsInChildren<Renderer>();
        foreach(var renderer in childRenderers) {
            renderer.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(CameraRotation.rotationY < -30.0f) {
            foreach(var renderer in childRenderers) {
                renderer.GetComponent<MeshRenderer>().enabled = true;
            }
        } else {

            foreach(var renderer in childRenderers) {
                renderer.GetComponent<MeshRenderer>().enabled = false;
            }
        }

    }
}
