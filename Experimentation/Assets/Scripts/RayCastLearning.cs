using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RayCastLearning : MonoBehaviour
{

    public Vector3 collision;
    public LayerMask layer;

    public BasicDoor UIText;
    void Start()
    {
        UIText._text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    { 
        RaycastHit hit;
        var ray = new Ray(this.transform.position, this.transform.forward);
        Physics.Raycast(ray, out hit, 100);

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;


        if (Physics.Raycast(ray, out hit, 1))
        {
            if (hit.transform.tag == "cheapDoor")
            {
                UIText._text.enabled = true;
                UIText._text.text = "750 points crikey";
                if (Input.GetKey(KeyCode.H)) //&& playerPoints >= 750
                {
                    //playerPoints = playerPoints - 750;
                    Destroy(hit.transform.gameObject);
                    Debug.Log("Just bought the door");
                }
                Debug.DrawRay(transform.position, forward, Color.blue);
            }
        }

        if (!Physics.Raycast(ray, out hit, 1))
        {
            UIText._text.enabled = false;
        }
    }
}

