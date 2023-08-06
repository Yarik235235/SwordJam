using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform spawn;
    private Camera _camera;
    public float speed;
    public float rotationSpeed = 150f;

    public float offset;

    private float timer;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;

        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);

        transform.position += (_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - transform.position).normalized * speed * Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0.4f;
        }
    }
}
