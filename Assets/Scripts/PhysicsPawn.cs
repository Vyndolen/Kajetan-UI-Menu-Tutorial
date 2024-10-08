using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class PhysicsPawn : PawnBase
{

    private Rigidbody2D rigidbody;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void MoveByForce(Vector2 movement)
    {
        rigidbody.AddForce(movement, ForceMode2D.Force);
    }

}
