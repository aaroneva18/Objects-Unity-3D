using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionOpenDoor : Action
{
    [SerializeField] bool DoorIsOpen = false;   

    private void Awake() {
        SetDefaultActiontState();
    }

    public override void ExcecuteAction() {
        Debug.Log("Open Door"); 
        DoorIsOpen = true;
        animator.Play("OpenDoor");
    }

    public override void StopAction() {}

    public override void SetDefaultActiontState() {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

}
