using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float moveSpeed;
    public bool isMoving;
    public Vector2 input;

    public LayerMask solidObjectsLayer;
    public LayerMask EnemyLayer;



    private void Update()
    {
        if(!isMoving){
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if(input.x != 0) input.y = 0;

            if(input != Vector2.zero){
                var targetPosition = transform.position;
                targetPosition.x += input.x;
                targetPosition.y += input.y;

                if(isWalkable(targetPosition)){
                    StartCoroutine(Move(targetPosition));
                }
                
            }
        }

        
    }

    IEnumerator Move(Vector3 targetPosition){
        isMoving = true;

        while((targetPosition - transform.position).sqrMagnitude > Mathf.Epsilon){
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPosition;
        
        isMoving = false;

    }

    private bool isWalkable(Vector3 targetPosition){
        if(Physics2D.OverlapCircle(targetPosition, 0.2f, solidObjectsLayer) != null){
            return false;
        }
        return true;
    }
}
