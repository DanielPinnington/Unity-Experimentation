using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;

public class BasicDoor : MonoBehaviour
{
    [SerializeField] GameObject _doorsParent;
    [SerializeField] public TextMeshProUGUI _text;
    [SerializeField] List<GameObject> _Doors;
    public List<GameObject> children;

    // Start is called before the first frame update
    void Start()
    {
        //_text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        var playerTag = col.gameObject.tag == "Player";

        if (playerTag)
        {
            _Doors.Contains(GameObject.FindWithTag("cheapDoor"));
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            {
                _text.enabled = false;
            }
        }
    }
}
