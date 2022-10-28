using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;
    public int currency = 5;
    Node nodescript;

    void Start()
    {
        buildManager = BuildManager.instance;
        
    }

  
    
    public void PurchaseStandardTurret()
    {
        if(currency == 5)
        {
            Debug.Log("Standard Turret Purchased");
            buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
            currency -= 5;
        }
        if (currency > 5)
        {
            CanPlace = false;
        }
        
    }
}
