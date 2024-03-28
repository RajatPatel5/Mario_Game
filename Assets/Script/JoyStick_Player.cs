using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JoyStick_Player : MonoBehaviour
{
    public FixedJoystick fixedJoystick;
    public float diff = 1;
    public GameObject player;
    public Transform Player_2;
    public GamePlay_Canvas GamePlayCanvas;
    public GameObject Coin;
    private GameObject collidedCoin;
    public Npc_player Enemy;
    public float Enemy_Position;
    public float Player_Position;
    public float Enemy_postion_onexit;
    public float Player_postion_onexit;
    public float Distance;


    public Vector3 currentTargetPosition;

    void Update()   
    {


        if (fixedJoystick.Horizontal > 0.1f)
        {
            Quaternion newRotation = Quaternion.Euler(0, 0, 0);
            player.transform.rotation = newRotation;
            Vector3 newPos = new Vector3(fixedJoystick.Horizontal, 0);
            transform.position += newPos * diff * Time.deltaTime;
        }

        else if (fixedJoystick.Horizontal < -0.1f)
        {

            Quaternion newRotation = Quaternion.Euler(0, 180, 0);
            player.transform.rotation = newRotation;
            Vector3 newPos = new Vector3(fixedJoystick.Horizontal, 0);
            transform.position += newPos * diff * Time.deltaTime;
        }
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Coin")) 
        {
            GamePlayCanvas.CoinCount();

            collidedCoin = col.gameObject;
            collidedCoin.SetActive(false);
       
        }

        if(col.gameObject.CompareTag("Attack"))
        {
           Enemy_Position = Enemy.transform.position.x;
           Player_Position = player.transform.position.x;

            if(Player_Position > Enemy_Position )
            {
                Quaternion newRotation_1 = Quaternion.Euler(0, 0, 0);
                Enemy.transform.rotation = newRotation_1;
                EnemymovetoPlayer();
            }
            else
            {
                Quaternion NewRotation_2 = Quaternion.Euler(0, 180, 0);
                Enemy.transform.rotation = NewRotation_2;
                EnemymovetoPlayer();


            }
        }   
    }
    public void OnTriggerStay2D(Collider2D col2)
    {
        if (col2.gameObject.CompareTag("Attack"))
        { // Enemy_Position = Enemy.transform.position.x;
            // Player_Position = player.transform.position.x;
            Distance = Player_2.transform.position.x - Enemy.transform.position.x;
            
            if (Distance < 0.3)
            {
                Debug.Log("Animation  call");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Attack"))
        {
            Enemy.currentTargetPosition = Enemy.Tg1;
            Quaternion NewRotation_2 = Quaternion.Euler(0, 180, 0);
            Enemy.transform.rotation = NewRotation_2;


        }

    }

    public void EnemymovetoPlayer()
    {
        Enemy.currentTargetPosition = Player_2;
    }
}
