using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    private Collider2D collide;
    private bool facingRight;

    private int moveX;
    // Start is called before the first frame update
    void Start()
    {
        collide = GetComponent<Collider2D>();
        facingRight = true;
        moveX = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x += moveX * movementSpeed * Time.deltaTime;
        if(collide.isTrigger && facingRight){
            facingRight = !facingRight;
            moveX = -1;
        }
        else if(collide.isTrigger && !facingRight){
            facingRight = !facingRight;
            moveX = 1;
        }
        transform.position = position;
    }
}
