using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction = new Vector3(-1f, 0f, 0f); // Vector3.Forward
    public float speed = 2f;
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
