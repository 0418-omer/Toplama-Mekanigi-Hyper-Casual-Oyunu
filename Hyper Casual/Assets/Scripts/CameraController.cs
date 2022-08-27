using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;
    private Vector3 _offset;

    [SerializeField] private float _lerpTime;
    void Start()
    {
       _offset = _ballTransform.position - _ballTransform.position; 
    }

    
    void Update()
    {
        Vector3 _newPos = Vector3.Lerp(_ballTransform.position, _ballTransform.position + _offset,_lerpTime * Time.deltaTime);
    }
}
