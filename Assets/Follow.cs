using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private Camera playercam;
    private Camera cam;
    Vector3 point = new Vector3();
    void Start()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //playercam = GameObject.Find("Camera").GetComponent<Camera>();
        cam = Camera.main;
    }

    void Update()
    {
        
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
        this.transform.position = point;
    }
    void OnGUI()
    {
        
    }

}
