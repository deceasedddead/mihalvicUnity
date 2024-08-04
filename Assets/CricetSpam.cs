using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CricetSpam : MonoBehaviour
{
    public GameObject treeForDestroy;
    void Start()
    {
        Destroy(treeForDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        print("Cricket");
    }
}
