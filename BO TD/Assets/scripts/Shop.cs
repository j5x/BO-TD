using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;
    public int currency = 5;
    Node nodescript;
    bool canPlace = false;
    

    void Start()
    {
        buildManager = BuildManager.instance;
        
    }
    internal void Update()
    {
        if(currency >= 5)
        {
            canPlace = true;
        }
        if(currency <= 5)
        {
            canPlace = false;
        }
    }


    public void PurchaseStandardTurret()
    {
        if(canPlace == true)
        {
            Debug.Log("Standard Turret Purchased");
            buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
            currency -= 5;
        }
       
        
    }
}
