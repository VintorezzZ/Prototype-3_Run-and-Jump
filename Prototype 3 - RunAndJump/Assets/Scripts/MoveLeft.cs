﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20f;
    private PlayerController playerControllerScript;
    private float leftBoundary = -15;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
            transform.Translate(Vector3.left * (Time.deltaTime * speed));
        
        if(transform.position.x<leftBoundary && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
