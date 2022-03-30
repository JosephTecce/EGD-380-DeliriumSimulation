using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectShake : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float randomness;

    Vector3 ogPosition;

    // Start is called before the first frame update
    void Start()
    {
        ogPosition = transform.position;

        StartCoroutine(Shake());
    }

    private IEnumerator Shake()
    {
        while (true)
        {
            transform.DOShakePosition(2, speed, 10, randomness, false, false);

            yield return new WaitForSeconds(1f);

            transform.position = ogPosition;
        }

    }
}
