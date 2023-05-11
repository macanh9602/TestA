using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManager : MonoBehaviour
{
    public GameObject target;
    float minX = -11;
    float minY = 2;
    float maxX = 11;
    float maxY = 4;
    float spacing = 2;
    // Start is called before the first frame update
    void Start()
    {
        for (float x = minX; x <= maxX; x += spacing)
        {
            for (float y = minY; y <= maxY; y += spacing)
            {
                Vector3 position = new Vector3(x, y, 0f);
                Instantiate(target, position, Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
