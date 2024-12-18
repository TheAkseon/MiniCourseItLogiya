using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator Animator;

    public void Run(bool isRunning)
    {
        Animator.SetBool("IsRunning", isRunning);
    }

    public void Idle(bool isIdle)
    {
        Animator.SetBool("IsIdle", isIdle);
    }
}
