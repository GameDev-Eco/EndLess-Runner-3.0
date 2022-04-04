using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerAnimationController : MonoBehaviour
{
    PlayerController player;

    [SerializeField] Animator animator;

    private void Awake()
    {
        player = GetComponent<PlayerController>();
    }

    private void Update()
    {
        animator.SetBool(PlayerAnimationConstants.IsJumping, player.IsJumping);    
    }

    public void Die() 
    {
        animator.SetTrigger(PlayerAnimationConstants.Die);
    }
}
