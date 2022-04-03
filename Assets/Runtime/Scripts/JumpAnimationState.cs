using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpAnimationState : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //duracao da animacao de pulo
        AnimatorClipInfo[] clips = animator.GetNextAnimatorClipInfo(layerIndex);
        if (clips.Length > 0)
        {
            AnimatorClipInfo jumpClipInfo = clips[0];

            //duracao do pulo na gameplay
            PlayerController player = animator.transform.parent.GetComponent<PlayerController>();

            //setar o jumpMultiplier para que a duracao da animacao de pulo seja = a duracao do pulo na gameplay
            float multiplier = jumpClipInfo.clip.length / player.JumpDuration;
            animator.SetFloat(PlayerAnimationConstants.JumpMultiplier, multiplier); 
        }
    }
}
