using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class ToolTest : MonoBehaviour
{
    public BarrelType barrelType;

    MaterialPropertyBlock mbp;
    static readonly int shPropColor = Shader.PropertyToID("_Color");

    MaterialPropertyBlock Mbp
    {
        get
        {
            if(mbp == null)
            {
                mbp = new MaterialPropertyBlock();
            }
            return mbp;
        }
    }

    void TryApplyColor()
    {
        if (barrelType == null)
            return;

        MeshRenderer mr = GetComponent<MeshRenderer>();
        Mbp.SetColor(shPropColor, barrelType.color);
        mr.SetPropertyBlock(Mbp);
    }

    private void OnEnable()
    {
        TryApplyColor();
        /*
        //Editor safe way of creating a material
        //if you dont want the new mat saved to the scene
        //or saved as an asset
        Shader shader = Shader.Find("Default/Diffuse");
        Material mat = new Material(shader);
        mat.hideFlags = HideFlags.HideAndDontSave;

        //Will duplicate the material
        GetComponent<MeshRenderer>().material.color = Color.red;

        //Will modify the asset
        GetComponent<MeshRenderer>().sharedMaterial.color = Color.red;
        */
    }

    //Calls on property change
    private void OnValidate()
    {
        TryApplyColor();
    }

    private void OnDisable()
    {

    }

    private void OnDrawGizmosSelected()
    {
        if (barrelType == null)
            return;

        Handles.color = barrelType.color;
        Handles.DrawWireDisc(transform.position, transform.up, barrelType.radius);
        Handles.color = Color.white;
        //Gizmos.DrawWireSphere(transform.position, radius);
    }
}
