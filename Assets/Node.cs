using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown ()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;
        if (turret != null)
        {
            return;
        }

        GameObject turretToBuild = buildManager.GetTurretToBuild();
        /*urret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform)*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
