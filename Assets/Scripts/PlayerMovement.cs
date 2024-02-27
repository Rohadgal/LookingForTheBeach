using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator animator;
    static public bool isPlayerMoving;

    void Start(){
        animator = GetComponent<Animator>();
    }

    void Update(){
        walkInPlace();
    }

    void walkInPlace(){
        float verticalInput = Input.GetAxisRaw("Vertical");

        if(verticalInput != 0){
            animator.SetBool("isWalking", true);
            isPlayerMoving = true;
            return;
        }
        animator.SetBool("isWalking", false);
        isPlayerMoving = false;
    }

    public bool getIsPlayerMoving() {
        return isPlayerMoving;
    }
}
