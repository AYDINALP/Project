using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_control : MonoBehaviour
{
    public float hiz;
    void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
    }
}