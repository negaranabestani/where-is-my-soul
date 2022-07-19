using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFallingObjects : MonoBehaviour
{

    public WhereIsMySoulManager manager;
    public GameObject starsParent;
    public GameObject soulGrabbersParent;
    // -9 to 7.5

    private Transform[] stars;
    private Transform[] soulGrabbers;

    private void Start()
    {
        stars = starsParent.GetComponentsInChildren<Transform>();
        soulGrabbers = soulGrabbersParent.GetComponentsInChildren<Transform>();
        print("strs: " + stars.Length);
        print("grbs: " + soulGrabbers.Length);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.StartsWith("star"))
        {
            manager.soul++;
        }
        else
        {
            manager.soul--;
        }

        other.gameObject.SetActive(false);
        
        other.gameObject.transform.position = new Vector3(0, 3.5f, 0);
        
        other.gameObject.SetActive(true);

    }
}