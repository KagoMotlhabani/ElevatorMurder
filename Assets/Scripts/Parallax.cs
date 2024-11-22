using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is from the tutorial by Raycastly on YouTube (https://www.youtube.com/watch?v=B40xBPXK97A)

public class Parallax : MonoBehaviour
{
    public float offsetMultiplier = 1;
    public float smoothTime = 0.3f;
    public Vector2 startPosition;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = Vector3.SmoothDamp(transform.position, startPosition + (offset * offsetMultiplier), ref velocity, smoothTime);
        
    }
}
