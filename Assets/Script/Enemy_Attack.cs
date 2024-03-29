using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public Npc_player Enemy;
    public JoyStick_Player Player;
    public GamePlay_Canvas Canvas;
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && Enemy.IsenemyattackAnimationOver)
        {
            Player.OnEnemyAttack();
            Enemy.IsenemyattackAnimationOver = false;
            Canvas.healthCount();
        }
    }

}
