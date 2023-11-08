using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObject : MonoBehaviour
{
    private Vector3 initialLocalScale;

    private void Start()
    {
        // Record the initial local scale of the child object when the game starts
        initialLocalScale = transform.localScale;
    }

    private void LateUpdate()
    {
        // Ensure that the child object maintains its initial local scale
        transform.localScale = initialLocalScale;
    }
}
