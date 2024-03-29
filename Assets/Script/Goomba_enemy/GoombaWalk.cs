using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaWalk : MonoBehaviour
{
    public Transform currentPosition;
    public Transform Target1;
    public Transform Target2;
    public float moveSpeed;
    public float diff;
    public GameObject GoombaEnemy;
    public Rigidbody2D Rb;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentPosition = Target1;
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 poss = currentPosition.transform.position;
        poss.y = transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, poss, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentPosition.position) < diff)
        {
            if (currentPosition == Target1)
            {

                currentPosition = Target2;


            }
            else
            {
                currentPosition = Target1;

   
            }
        }
    }

    public void Head_goomba()
    {
        Rb.constraints = RigidbodyConstraints2D.FreezeAll;
        animator.SetTrigger("Flat");
      //  GoombaEnemy.SetActive(false);
    }
    //harshil 
   
    }

