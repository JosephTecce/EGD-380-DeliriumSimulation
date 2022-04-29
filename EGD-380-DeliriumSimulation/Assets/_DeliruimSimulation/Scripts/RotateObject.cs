using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Vector3 _rotation;
    [SerializeField] private float _speed = 10f;


    private void Update()
    {
        // reset rotation value of object
        _rotation = Vector3.zero;

        // do the stupidest thing I've ever written. 
        // i won't even comment how this works because you shouldn't do it this way,
        // you should completely re-write it from scratch using Unity's input axis system and Quaternions and also use the mouse to rotate the model
        
        if ( Input.GetKey( KeyCode.A ) || Input.GetKey( KeyCode.LeftArrow) )        _rotation = Vector3.up;
        else if ( Input.GetKey( KeyCode.D ) || Input.GetKey( KeyCode.RightArrow ) ) _rotation = Vector3.down;
        else if ( Input.GetKey( KeyCode.W ) || Input.GetKey( KeyCode.UpArrow) )     _rotation = Vector3.right;
        else if ( Input.GetKey( KeyCode.S ) || Input.GetKey( KeyCode.DownArrow) )   _rotation = Vector3.left;

        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }



}
