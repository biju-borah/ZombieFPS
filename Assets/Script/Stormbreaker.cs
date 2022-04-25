using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stormbreaker : MonoBehaviour
{
    public float Speed = 10f;
    private Transform Enemy;
    private bool Attacking = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Attacking)
        {
            Enemy = GameObject.FindWithTag("Enemy").transform;
            if(Enemy != null)
            {
                Attack();
            }
            else
            {
                Attacking = false;
            }
            
        }
        if(Input.GetMouseButton(0))
        {
            Attacking = true;
        }
    }
    void Attack()
    {
        transform.LookAt(Enemy);
        transform.position = Vector3.MoveTowards(transform.position,new Vector3(Enemy.position.x,Enemy.position.y+1,Enemy.position.z),Speed); 
    }

}
