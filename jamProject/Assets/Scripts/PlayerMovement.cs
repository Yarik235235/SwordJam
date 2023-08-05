using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform spawn;
    private Camera _camera;
    public int speed;
    public float rotationSpeed = 180f;

    public float offset;

    private float timer;
    public GameObject line;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        float dist = Vector3.Distance(_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y)), transform.position);

        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);

        transform.position += (_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - transform.position).normalized * speed * Time.deltaTime;

        if (timer <= 0)
        {
            //Instantiate(line, spawn.position, spawn.rotation);
            timer = 0.4f;
        }

    }

}
