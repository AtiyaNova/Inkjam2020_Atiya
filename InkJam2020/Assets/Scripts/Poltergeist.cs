using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poltergeist : MonoBehaviour
{
    [SerializeField]
    private float floatVal = 0.1f;
    private float addedY = 0.1f;

    private void Start()
    {
        addedY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, (float)(Mathf.Sin(Time.time) * floatVal) + addedY, transform.position.z);
    }
}
