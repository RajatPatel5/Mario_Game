using UnityEngine;

public class Npc_player : MonoBehaviour
{
    public Transform targetPosition1;
    public Transform targetPosition2;
    public float moveSpeed = 5f;
    public float stopDurationMin = 2f;
    public float stopDurationMax = 5f;
    public GameObject Enemy;
    private Transform currentTarget;
    private bool isMoving = true;
    private float stopDurationTimer;

    private void Start()
    {
        currentTarget = targetPosition1;
    }

    private void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, moveSpeed * Time.deltaTime);

            if (transform.position == currentTarget.position)
            {
                if (currentTarget == targetPosition1)
                {
                    currentTarget = targetPosition2;
                    
                    Enemy.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                }
                else
                {
                    currentTarget = targetPosition1;
                   
                    Enemy.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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
