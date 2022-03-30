using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// Author: Wesley Elmer
// Client: Healthy Design - Delirium Simulation
// Date  : 3/30/2022

public class ObjectFader : MonoBehaviour
{
    [Header( "NOTE: Ensure that the material attached to this object is able to render transparently, otherwise this script will do nothing." )]

    public Material material;

    /// <summary>
    /// Fade the transparency of this object's material to the set value over specified duration.
    /// </summary>
    /// <param name="alpha">The target alpha to change to</param>
    /// <param name="duration">The amount of time the fade will take</param>
    public void Fade(float alpha, float duration)
    {
        material.DOFade( alpha, duration );
    }

    [ContextMenu("DEBUG | Fade object to transparent")]
    private void TestFadeScript()
    {
        Fade( 0, 1 );
    }

    private void OnDestroy()
    {
        Color color = material.color;
        color.a = 1f;
        material.color = color;
    }
}
