using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_test : MonoBehaviour
{
    public Animator animator;
    public Animation cube;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Jump bool" ,true);
        animator.SetBool("Jump bool", false);

        animator.SetTrigger("Attack trigger");
        animator.SetInteger("Damage int", 20);
        //animator.SetFloat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        animator.SetTrigger("Attack trigger");
    }

    public void Damage()
    {
        animator.SetInteger("Damage int", 20);
    }
}
