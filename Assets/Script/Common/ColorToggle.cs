using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorToggle : MonoBehaviour
{
    public Material PinkMaterial = null;
    public Material GreyMaterial = null;

    private bool isPink = true;

    public void ToggleColor()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        isPink = !isPink;
        if (isPink)
        {
            renderer.material = PinkMaterial;
        }
        else
        {
            renderer.material = GreyMaterial;
        }
    }
}
