﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    [SerializeField] private float Speed = 3;

    void Update()
    {

        if (transform.position.x <= -8)
        {
            score++;
            Destroy(gameObject);
        }



        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
    }

}

