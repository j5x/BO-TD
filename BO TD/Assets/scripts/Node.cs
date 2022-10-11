using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;

    public Vector3 positionOffset;

    private Renderer rend;
    public Color startColor;

    BuildManager buildManager;


    void  Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }
    void OnMouseDown()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;

       if (turret != null)
        {
            Debug.Log("nigga");
            return;

        }
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        turret.transform.parent = transform;
    }
    private void OnMouseEnter()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;
        rend.material.color = hoverColor;
        
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
