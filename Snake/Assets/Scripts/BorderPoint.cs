using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderPoint : MonoBehaviour
{
    public Renderer Renderer;

    private void Awake() 
        => Renderer = GetComponent<Renderer>();
}
