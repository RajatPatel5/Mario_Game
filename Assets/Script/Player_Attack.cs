using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public Npc_player Enemy;
    public JoyStick_Player Player;
    public void OnTriggerStay2D(Collider2D col)
    {
       

        if (col.gameObject.CompareTag("Enemy") && Player.IsAnimationOver)
        {
            
            Enemy.EnemyHealthDown();
           
            Player.IsAnimationOver = false;
        }
    }

}
