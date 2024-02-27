using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class TillingDisplacement : MonoBehaviour
{
   public float scrollSpeed = 1.0f;

    void Update()   {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            float offset = (Time.time * scrollSpeed) * 0.5f;
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, -offset);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            float offset = (Time.time * scrollSpeed) * 0.5f;
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, offset);
        }
    }
}
