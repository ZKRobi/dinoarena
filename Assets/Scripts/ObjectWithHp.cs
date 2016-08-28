using UnityEngine;
using System.Collections;

public class ObjectWithHp : MonoBehaviour
{
    public float maxHp = 100;

    public float CurrentHp { get; private set; }

    public void ChangeHpBy(float value)
    {
        CurrentHp += value;
        if (CurrentHp > maxHp)
        {
            CurrentHp = maxHp;
        }
        Debug.Log("Hp changed to " + CurrentHp);
    }

    // Use this for initialization
    void Start()
    {
        CurrentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHp <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
