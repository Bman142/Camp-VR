using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BzKovSoft.ObjectSlicer;

public class Destruction_SlicerController : MonoBehaviour
{

    public GameObject _target;

    void Start()
    {
        var sliceable = _target.GetComponent<IBzSliceable>();

        if (sliceable != null)
        {
            print("sliceable does not equal null");
            sliceable.Slice(new Plane(Vector3.up, 0), null);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
