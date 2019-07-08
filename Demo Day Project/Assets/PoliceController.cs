﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
    public float speed;
    private float distance;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
         target.position, speed * Time.deltaTime);
        distance = Vector3.Distance(target.position, transform.position);
        if (distance > 10)
        {
            //transform.position = Vector2.MoveTowards(transform.position,
            //target.position, speed * Time.deltaTime);
        }
    }
  
}
