using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObject : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 1f;

    private float maxScale = 3f;
    private float minScale = 0.5f;
    

    private void Update()
    {
        float scaleFactor = Mathf.Sin(Time.time * scaleSpeed);

        float newScale = Mathf.Lerp(minScale, maxScale, (scaleFactor + 1f) / 2f);

        transform.localScale = new Vector3(newScale, newScale, 1f);
    }
}
