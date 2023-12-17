using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float HorzDir;
    float VertDir;
    [SerializeField] float moveSpeed;
    Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorzDir = Input.GetAxisRaw("Horizontal");
        VertDir = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
        playerRigidBody.velocity = new Vector2(HorzDir * moveSpeed, VertDir * moveSpeed);
    }
}
