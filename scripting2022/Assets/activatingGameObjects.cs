using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatingGameObjects : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }
    public GameObject myObject;
    void Update()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}
