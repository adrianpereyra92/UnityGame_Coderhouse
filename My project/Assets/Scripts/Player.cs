using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float playerSpeed = 5f;
    public int hp = 3;
    public string playerName = "player";

    public int hit = 2;
    public int life = 1;
    void Start() {
        Damage(hit);
        Health(life);
        Debug.Log("START");

    }

    void Update()
    {
        //Damage();
        Movement(Vector3.right);
        Debug.Log("UPDATE");

    }

    private void Movement(Vector3 direction)
    {
        transform.position += direction * playerSpeed * Time.deltaTime;
    }

    void Damage (int value) {
        hp += - value; 
    }

    void Health (int value) {
        hp += + value;
    }

}