using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BarrelType : ScriptableObject
{
    [Range(1.0f, 20.0f)]
    public float radius = 1.0f;

    public float damage = 10.0f;
    public Color color = Color.red;
}
