using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f, 0f, 1f);
    public float speed = 3f;
    public float damage = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() 
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
