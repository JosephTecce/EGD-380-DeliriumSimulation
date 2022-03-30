using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Wesley Elmer

/// <summary>
/// This script is only meant to test the Object Fader script
/// </summary>
[RequireComponent(typeof(ObjectFader))]
public class ObjectFaderTest : MonoBehaviour
{
    public float alpha;
    public float duration;
    private ObjectFader objectFader;

    // Start is called before the first frame update
    void Start()
    {
        objectFader = GetComponent<ObjectFader>();
        objectFader.Fade( alpha, duration );
    }
}
