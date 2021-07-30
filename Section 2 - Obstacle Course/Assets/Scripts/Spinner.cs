using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float yAngle = 0f;
    private Rigidbody _rb;
    Vector3 m_EulerAngleVelocity;
    
    void Start()
    {
        m_EulerAngleVelocity = new Vector3(0, yAngle, 0);
    }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * deltaRotation);
    }
    
    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    // // Update is called once per frame
    // void Update()
    // {
    //     _rb.rotation
    // }
}
