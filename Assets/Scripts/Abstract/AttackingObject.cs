using UnityEngine;
using System.Collections;

public abstract class AttackingObject : MonoBehaviour
{
    public float attackInterval = 1;
    public float attackRange = 0.1f;
    public LayerMask layerFilter;

    private float lastAttack = 0;

    protected virtual void Start()
    {
        lastAttack = attackInterval;
    }

    protected virtual void Update()
    {
        var attackedObjects = Physics2D.OverlapCircleAll(this.transform.position, attackRange);
        lastAttack += Time.deltaTime;
        if (lastAttack > attackInterval)
        {
            foreach (var item in attackedObjects)
            {
                if (item.gameObject.layer == Mathf.Log(layerFilter.value, 2)) // good enough for 1 layer
                {
                    lastAttack = 0;
                    if (!PerformAttack(item.gameObject))
                    {
                        break;
                    }
                }
            }
        }
    }

    protected abstract bool PerformAttack(GameObject target);
}
