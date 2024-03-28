
using UnityEngine;


public class Npc_player : MonoBehaviour
{
    public Transform target_Position1;
    public Transform target_Position2;
    public Transform Tg1;
    public float moveSpeed = 5f;
    public float stopDurationMin = 2f;
    public float stopDurationMax = 5f;
    public GameObject Enemy;
    public Transform currentTargetPosition;  
    private bool isMoving = true;
    private float stopDurationTimer;
    public Animator enemy_animation;
    public GameObject Player;
    public float diff = 1;
    void Start()
    {
        Tg1 = target_Position1;
        currentTargetPosition = target_Position1;

    }

    void Update()
    {
        if (isMoving)
        {
            Vector3 poss = currentTargetPosition.transform.position;
            poss.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, poss, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position,currentTargetPosition.position) < diff)
            {
                if (currentTargetPosition == target_Position1)
                {
                   
                    currentTargetPosition = target_Position2;

                    Enemy.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                }
                else
                {
                    currentTargetPosition = target_Position1;

                    Enemy.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                }

                stopDurationTimer = Random.Range(stopDurationMin, stopDurationMax);

                isMoving = false;
            }
        }
        else
        {
            stopDurationTimer -= Time.deltaTime;

            if (stopDurationTimer <= 0f)
            {
                isMoving = true;
            }
           
        }
    }
}

