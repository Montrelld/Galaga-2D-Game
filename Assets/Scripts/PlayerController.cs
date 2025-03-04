using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    private Rigidbody2D rigidbody2d;
    Vector2 move;

    public GameObject projectilePrefab;
    
    
   



    // Variables related to animation
    
    Vector2 moveDirection = new Vector2(1,0);

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
       
     
    }

    // Update is called once per frame
    void Update()
    {   
         move = MoveAction.ReadValue<Vector2>();
         
         if (Input.GetKeyDown(KeyCode.Space))
         {
            
            Shoot();
         }

    }

    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * 5.0f * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    void Shoot()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(Vector2.up,4000);
    }

}