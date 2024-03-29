using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba_head_script : MonoBehaviour
{
    public GoombaWalk Goomba;
    // Start is called before the first frame update
    void Start()
    {

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

        }
    }
}
    
