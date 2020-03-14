using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFlint : MonoBehaviour
{
    public Transform Flint;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Flint.position + offset;
    }
}
