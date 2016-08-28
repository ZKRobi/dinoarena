using UnityEngine;
using System.Collections;

public class DamagingObject : MonoBehaviour
{

    public float Damage
    {
        get; set;
    }

    public LayerMask LayerFilter { get; set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerFilter.value)
        {
            var damageable = other.gameObject.GetComponent<ObjectWithHp>();
            if (damageable != null)
            {
                damageable.ChangeHpBy(-1 * Damage);
            }
            GameObject.Destroy(this);
        }
    }
}
