using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScrollBuildings : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;

    private void Update() {

       if(!PlayerMovement.isPlayerMoving) {
            return;
       }
       transform.position += (Vector3.forward * -speed * Time.deltaTime);
        //Debug.Log(transform.position);
    }
}
