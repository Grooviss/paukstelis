using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
    
{
    public float speed;
    public float startx;
    public float endx;
    private void Start()
    {
        startx = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x - 1;
        endx = Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x + 1;
    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < startx)
        {
            var height = Random.Range(-1f, 4f);
            transform.position = new Vector3(endx, height);
        }
    }
}
