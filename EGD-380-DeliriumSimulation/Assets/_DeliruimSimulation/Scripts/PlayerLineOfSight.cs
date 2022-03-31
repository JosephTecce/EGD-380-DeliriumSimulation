using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Wesley Elmer
// Client: Healthy Design - Delirium Simulation
// Date  : 3/30/2022

/// <summary>
/// Throws a ray out of the players head, allowing us to evoke triggers on the LineOfSight layer when the player looks at them.
/// </summary>
public class PlayerLineOfSight : MonoBehaviour
{
    [SerializeField] private LayerMask lineOfSightLayer;
    [SerializeField] private Transform playerCamera;
    [SerializeField] private float maxDistance = 5000f;

    private void FixedUpdate()
    {
        Physics.Raycast( playerCamera.position, playerCamera.forward, maxDistance, lineOfSightLayer, QueryTriggerInteraction.Collide); // QueryTriggerInteraction.Collide allows this ray to collide w/ triggers
    }

    private void OnDrawGizmosSelected()
    {
        Debug.DrawRay( playerCamera.position, playerCamera.forward );
    }
}
