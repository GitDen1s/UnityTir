using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shot : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] Text _num;

    private float _reloadTime = 0;
    private int _numbers = 0;
    private RaycastHit _hit;
    private Ray _ray;

    void Update()
    {
        Shoot();
        if (_numbers == 3)
        {
            _num.text = "Òû גûידנאכ!!!";
        }
    }
    private void Shoot()
    {
        if (Input.GetMouseButton(0))
        {

            _ray = _camera.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(_ray.origin, _ray.direction * 10, Color.green);
            if (Physics.Raycast(_ray, out _hit))
            {
                if (_hit.transform.CompareTag("Target"))
                {
                    _numbers++;
                    _num.text = _numbers.ToString();
                    Destroy(_hit.transform.gameObject);

                }

            }
        }
    }
}
