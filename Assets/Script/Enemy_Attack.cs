using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public Npc_player Enemy;
    public JoyStick_Player Player;
    // Start is called before the first frame update
   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && Enemy.IsenemyattackAnimationOver)
        {
            Player.OnEnemyAttack();
            Enemy.IsenemyattackAnimationOver = false;
        }
    }

}
