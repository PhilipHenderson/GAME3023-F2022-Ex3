using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterMovement : MonoBehaviour
{
    [SerializeField]
    [Range(0,100)] 
    private float MoveSpeed = 10;

    [SerializeField]
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector3 oldPosition = transform.position;

        rigidbody.MovePosition(oldPosition + new Vector3(xInput, yInput, 0) * MoveSpeed * Time.deltaTime);
        //transform.position = oldPosition + new Vector3(xInput, yInput, 0) * MoveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player Collided with " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player Triggered with: " + collision.gameObject.name);
    }

}
