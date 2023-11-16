
using UnityEngine;


public class ChangeOfMovementVertically : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    
    private float upperBound = 2f;
    private float lowerBound = -2f;
    
    private float t = 0f;
    
    
    private void Update()
    {
        // Изменяем параметр t от 0 до 1 с использованием синусоидальной функции
        t = Mathf.PingPong(Time.time * moveSpeed, 1f);

        // Используем функцию Lerp для плавного изменения положения
        float newY = Mathf.Lerp(lowerBound, upperBound, t);

        Vector3 curenntPosition = transform.localPosition;

        // Устанавливаем новую позицию в локальных координатах
        transform.localPosition = new Vector3(curenntPosition.x, newY, 0f);
    }
}
