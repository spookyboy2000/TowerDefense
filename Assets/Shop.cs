using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;   
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public GameObject turret;
    //BuildManager buildManager;

    // Start is called before the first frame update
    void Start()
    {
        //buildManager = BuildManager.instance;
    }



    public void SelectStandard()
    {
        //buildManager.SelectTurretToBuild(buildManager.SelectStandard);

        
        Instantiate(turret, new Vector3(), Quaternion.identity);
    }
}
