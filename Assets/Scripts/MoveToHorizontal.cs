
using System;
using UnityEngine;

public class MoveToHorizontal : MonoBehaviour
{

    [SerializeField] private float speed = 2f;

    private float leftBound = -4f;
    private float rightBound = 4f;
    private void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);

        if (newPosition.x < leftBound || newPosition.x > rightBound)
        {
            speed = -speed; // Изменяем направление движения
        }

        transform.position = newPosition;
    }
}
