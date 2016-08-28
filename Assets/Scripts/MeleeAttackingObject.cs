using UnityEngine;
using System.Collections;
using System;

public class MeleeAttackingObject : AttackingObject
{

    public float damage;

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override bool PerformAttack(GameObject target)
    {
        var damageable = target.GetComponent<ObjectWithHp>();
        if (damageable != null)
        {
            damageable.ChangeHpBy(-1 * damage);
        }
        return true;
    }
}
