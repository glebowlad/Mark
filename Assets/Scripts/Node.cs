using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color HoverColor;
    private Color startColor;
    private Renderer renderer;
    void Start()
    {
        renderer  = GetComponent<Renderer>();
        startColor = renderer.material.color;
    }
    private void OnMouseEnter()
    {
        renderer.material.color = HoverColor;
    }
    private void OnMouseDown()
    {
        
    }
    private void OnMouseExit()
    {
        renderer.material.color = startColor;
    }
}