using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : TopDownAnimations
{
    // Start is called before the first frame update
    void Start()
    {
        controller.onMoveEvent += Animaion;
    }

    private void Animaion(Vector2 direction)
    {
        animator.SetBool("IsWalking",direction.magnitude>0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
