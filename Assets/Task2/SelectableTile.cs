using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableTile : MonoBehaviour
{
    private Material _material;
    private Color _color;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _color = _material.color;
    }

    private void OnMouseEnter()
    {
        _material.color = Color.gray;
    }

    private void OnMouseExit()
    {
        _material.color = _color;
    }

    // Update is called once per frame
    void Update()
    {
    }
}