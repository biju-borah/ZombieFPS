using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject TheEnemy;
    public float xpos;
    public float ypos;
    public float zpos;
    public int EnemyCount = 0;
    public int Enemyno;
    public int timebetwave;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemyDrop()
    {
        while(EnemyCount<Enemyno)
        {
            Instantiate(TheEnemy,new Vector3(xpos,ypos,zpos),Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            EnemyCount++;
        }
    }
}

