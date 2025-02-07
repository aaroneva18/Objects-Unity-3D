using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAction : Action
{
    [SerializeField] private int heal = 0;

    private void Awake() {
        SetDefaultActiontState();
    }

    public override void ExcecuteAction() {
        playerManager.Heal(heal);
    }

    public override void StopAction() {}

    public override void SetDefaultActiontState() {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }


}
