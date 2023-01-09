using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    const int AXIS_Y_POSITION = -4;
    private new Rigidbody2D rigidbody;
    private Vector2 movement;
    public float speed = 1f;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
        GenerateRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector2(moveHorizontal, 0f);
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(movement * speed * 5f);
    }
    private void GenerateRandomPosition()
    {
        Vector2 randomPosition = new Vector2(Random.Range(-9,9), AXIS_Y_POSITION);
        transform.position = randomPosition;
    }
}
