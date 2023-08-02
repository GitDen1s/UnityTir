using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    enum Axis
    {
        X, Y, Z
    } 

    [SerializeField] private float _speed = 2f;
    [SerializeField] private Axis _axis;
    [SerializeField] private float _distance;
    private int _diraction = 1;
    private Vector3 _startPoint;
    private Vector3 _finishPoint;

    void Start()
    {
        _startPoint = transform.position;
        _finishPoint = _startPoint;
        switch (_axis)
        {
            case Axis.X:
                _finishPoint.x += _distance;
                break;
            case Axis.Y:
                _finishPoint.y += _distance;
                break;
            case Axis.Z:
                _finishPoint.z += _distance;
                break;
        }
        
    }
    void Update()
    {
        if(_diraction== 1)
        {
            Move(_finishPoint);
        }
        else
        {
            Move(_startPoint);
        }
    }
    void Move(Vector3 destination)
    {
        transform.position=Vector3.MoveTowards(transform.position,destination, _speed*Time.deltaTime);
        if (Vector3.Distance(transform.position, destination) <= 0.01f)
            _diraction = -_diraction;
    }
}
