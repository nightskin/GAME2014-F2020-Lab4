using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCorntoller : MonoBehaviour
{
    public  float horSpeed;
    public float horBounds;
    public int direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        transform.position += new Vector3(horSpeed * direction * Time.deltaTime, 0, 0);
    }
    private void CheckBounds()
    {
        if(transform.position.x >= horBounds || transform.position.x <= -horBounds)
        {
            direction *= -1;
        }
    }
}
