using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightAction : Action
{
    private void Awake() {
        SetDefaultActiontState();    
    }

    public override void ExcecuteAction() {
        Debug.Log("Flashlight collected");
    }


    public override void StopAction() {}

    public override void SetDefaultActiontState() {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
}
