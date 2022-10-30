using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public Vector2Int foodGridPosition;
    public Vector3 StartPosition;
    public Rigidbody2D RB;
    private int width;
    private int height;

    public Food(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    void Start()
    {
        StartPosition = transform.position;
        spawnFood();
    }

    public void spawnFood()
    {
        print("position changée");
        foodGridPosition = new Vector2Int(Random.Range(0, width), Random.Range(0, height));
        transform.position = new Vector3(foodGridPosition.x, foodGridPosition.y);
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("collide");
        if (collision.gameObject.CompareTag("Snake"))
        {
            spawnFood();
            print("Snake ate food !");
        }
    }
    void Update()
    {
        
    }
}
