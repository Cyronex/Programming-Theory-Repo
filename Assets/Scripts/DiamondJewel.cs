using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondJewel : Gem
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateShape();
    }

    public void RotateShape()
    {
        transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
    }
}
