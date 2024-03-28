using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AnimationController : MonoBehaviour
{
    public Animator Enemy_Animation;
   
     void Start()
    {
        Enemy_Animation = GetComponent<Animator>();
    }
    public void Enemy_Attack()
    {
        Enemy_Animation.SetTrigger("Attack");
        
    }

    public void Enemy_dead()
    {
        Enemy_Animation.SetTrigger("Dead");
    }
    
}
