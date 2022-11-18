using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    public Animator animator;
    public VFXSequencer basicAttackSequencer;
    // Start is called before the first frame update
    void Start()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Q");
        } 

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("W");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("E");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("R");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("BasicAttack");
            basicAttackSequencer.PlaySequence();
        }
    }
}
