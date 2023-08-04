using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Camera _camera;
    public int speed = 3;

    public float offset;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {

        Vector3 diference = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y) - transform.position);
        float rotZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        transform.position += (_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5)) - transform.position).normalized * speed * Time.deltaTime;
    }

}
