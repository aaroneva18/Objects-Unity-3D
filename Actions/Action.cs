using UnityEngine;

public abstract class Action : MonoBehaviour
{
    protected Animator animator;
    protected PlayerManager playerManager;
    protected Rigidbody rb;
    public abstract void ExcecuteAction();
    public abstract void StopAction();
    public abstract void SetDefaultActiontState();
}
