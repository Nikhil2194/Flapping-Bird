using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    private void Update()
    {
        
        
    }


     public void Roatation()
    {
        this.transform.Rotate(45f, 45f, 45f);
    }
}
