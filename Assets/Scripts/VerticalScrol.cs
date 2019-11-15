﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScrol : MonoBehaviour
{

    [SerializeField] float scrollRate = 0.2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, scrollRate * Time.deltaTime));
    }
}
