using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Vector3 _rotation;
    [SerializeField] private float _speed;


    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) _rotation = Vector3.up;
        else if (Input.GetKey(KeyCode.D)) _rotation = Vector3.down;
        else _rotation = Vector3.zero;


        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }



}
