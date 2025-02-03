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
        if (!DoorIsOpen) {
            OpenDoor();
        } else {
            CloseDoor();
        }
    }

    public void OpenDoor() {
        animator.Play("OpenDoor");
        DoorIsOpen = true;
    }

    public void CloseDoor() {
        animator.Play("CloseDoor");
        DoorIsOpen = false;
    }

    public override void StopAction() {}

    public override void SetDefaultActiontState() {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

}
