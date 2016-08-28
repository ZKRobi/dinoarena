using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    new private Rigidbody2D rigidbody;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");

        //transform.position = (Vector2)transform.position + new Vector2(horizontalMovement, verticalMovement) * speed * Time.deltaTime;
        rigidbody.velocity = new Vector2(horizontalMovement, verticalMovement) * speed;
    }
}
