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
        animator.SetBool("IsJumping", player.IsJumping);    
    }
}
