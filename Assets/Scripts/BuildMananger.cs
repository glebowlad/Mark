using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMananger : MonoBehaviour
{
    public static BuildMananger Instance;   
    public GameObject standartTurretPrefab;
    private GameObject turretToBuild;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("buildMananger уже есть на сцене");
            return;
        }
        Instance = this;
    }
    void Start()
    {
        turretToBuild = standartTurretPrefab;

    }

    // Update is called once per frame
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
