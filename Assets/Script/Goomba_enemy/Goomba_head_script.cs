using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba_head_script : MonoBehaviour
{
    public GoombaWalk Goomba;
    public CircleCollider2D Goomba_enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        Goomba_enemy = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Goomba_Head"))
        {

            
            Goomba.Head_goomba();
            Goomba.enabled = false;

        }
    }
}
    
