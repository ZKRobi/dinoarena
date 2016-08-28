using UnityEngine;
using System.Collections;
using Pathfinding;

public class RandomMovementAI : MonoBehaviour
{
    public float directionChangeInterval = 10;

    private GameObject target;
    private AILerp ai;
    private float lastDirectionChange = 0;

    public void Start()
    {
        target = new GameObject();
        ai = GetComponent<AILerp>();

        ai.target = target.transform;


    }

    // Update is called once per frame
    void Update()
    {
        lastDirectionChange += Time.deltaTime;
        if (directionChangeInterval < lastDirectionChange)
        {
            Debug.Log("It's direction change o'clock");
            ChangeTarget();
            lastDirectionChange -= directionChangeInterval;

        }
        else if (ai.targetReached && lastDirectionChange > 1)
        {
            Debug.Log("Target reached");
            ChangeTarget();
            lastDirectionChange = 0;
        }
    }

    void ChangeTarget()
    {
        target.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
    }
}
