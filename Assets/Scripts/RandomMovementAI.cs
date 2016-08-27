using UnityEngine;
using System.Collections;
using Pathfinding;

public class RandomMovementAI : MonoBehaviour
{
    public float directionChangeInterval = 10;

    private int walkableNodes = 0;
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
            target.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
            lastDirectionChange -= directionChangeInterval;

            //ai.target = target.transform;
        }
    }
}
