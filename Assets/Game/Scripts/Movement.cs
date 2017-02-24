using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
public class Movement : MonoBehaviour 
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // turning

        // jumping

        // move
        Move();
    }

    private void Move()
    {
        animator.SetFloat("Forward", Input.GetAxisRaw("Vertical"));
    }

    private void Jump()
    {

    }
}
