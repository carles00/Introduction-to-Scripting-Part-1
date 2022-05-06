using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hayMachine : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalBoundary;
    public GameObject hayBale;
    public Transform haySpawn;
    public float shootInterval;
    private float shootTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        updateMovement();
        updateShooting();
    }

    void updateMovement(){
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput < 0 && transform.position.x > -horizontalBoundary) // 2
        {
        transform.Translate(transform.right * -movementSpeed * Time.deltaTime);
        }
        else if (horizontalInput > 0 && transform.position.x < horizontalBoundary) // 3
        {
        transform.Translate(transform.right * movementSpeed * Time.deltaTime);
        }
    }
    private void updateShooting(){
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0 && Input.GetKey(KeyCode.Space)) {
            shootTimer = shootInterval;
            shootHay();
        }
    }

    private void shootHay(){
        Instantiate(hayBale,haySpawn.position,Quaternion.identity);
    }
}
