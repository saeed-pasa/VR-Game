﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanves : MonoBehaviour
{

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            panel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.D)){
            panel.SetActive(false);
        }
    }
}
