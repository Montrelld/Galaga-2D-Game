using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{public float speed = 0;
    public float timer = 3;
    public int direction = 1;
    float changeTime;


    // Start is called before the first frame update
    void Start()
    {
        changeTime = timer; 
    }

    void Update()
    {
        changeTime -= Time.deltaTime;
        Vector2 position = transform.position;
        if (changeTime < 0 )
        {
            direction = -direction;
            changeTime = timer;
        }
        
        position.x = position.x + speed * direction  * Time.deltaTime;
        transform.position = position; }

}
    

