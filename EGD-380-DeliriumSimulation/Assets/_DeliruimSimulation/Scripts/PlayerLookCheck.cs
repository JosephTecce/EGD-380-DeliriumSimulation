using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Author: Wesley Elmer
// Client: Healthy Design - Delirium Simulation
// Date  : 3/30/2022

[RequireComponent(typeof(Collider))]
public class PlayerLookCheck : MonoBehaviour
{
    [Tooltip("The amount of time the player needs to look at the trigger to fire the event.")]
    public float lookDuration = 1f;

    [Space]

    [Tooltip("When the player looks at this collider, this event is fired.")]
    public UnityEvent onPlayerLook;

    // private

    private float _timer = 0f;
    private bool _runTimer = false;

    private void OnTriggerEnter( Collider other )
    {
        // HACK currently doesn't check if it's the player's line of sight colliding.
        _runTimer = true;
        _timer = 0f;
    }

    private void Update()
    {
        // run the timer
        if ( _runTimer )
        {
            _timer += Time.deltaTime;
        }

        // if timer is up, trigger event
        if(_timer >= lookDuration)
        {
            _runTimer = false;
            _timer = 0f;
            onPlayerLook.Invoke();
        }
    }

    private void OnTriggerExit( Collider other )
    {
        _runTimer = false;
    }



}
