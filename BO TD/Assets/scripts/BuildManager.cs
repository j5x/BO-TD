using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    Shop shopscript;

    public void Start()
    {
        
    }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager");
            return;
        }
        instance = this;
        
    }

    public GameObject standardTurretPrefab;
    



    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
        
    }
}
