using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    public LayerMask enemyLayer;

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Enemy"){
            if(Physics2D.OverlapCircle(collision.gameObject.transform.position, 0.2f, enemyLayer) != null){
            Destroy(collision.gameObject);
        }
        }
    }
}
