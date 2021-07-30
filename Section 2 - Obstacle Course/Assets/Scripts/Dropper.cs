using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 5f;

    private MeshRenderer _mesh;
    private Rigidbody _rb;
    
    // Start is called before the first frame update
    void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            _mesh.enabled = true;
            _rb.useGravity = true;
        }
    }
}
