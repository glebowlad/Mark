using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color HoverColor;
    private Color startColor;
    private Renderer renderer;
    private GameObject turret;
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
        if (turret != null)
        {
            Debug.Log("Турель уже построена");
            return;
        }
        GameObject turretToBuild = BuildMananger.Instance.GetTurretToBuild();
        turret=Instantiate(turretToBuild,transform.position, transform.rotation);
        
    }
    private void OnMouseExit()
    {
        renderer.material.color = startColor;
    }
}