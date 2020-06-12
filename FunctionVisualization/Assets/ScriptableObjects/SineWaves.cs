/*
 * Michael T. Miyoshi
 * 
 * First try at Scriptable Objects.
 * 
 * reference:
 * https://www.red-gate.com/simple-talk/dotnet/c-programming/how-to-use-scriptable-objects-in-unity/
 * 
 * The sine wave attributes.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "SineWaveAttributes", menuName = "Sine Wave/Attributes")]

public class SineWaves : ScriptableObject
{
    public float linewidth;
    public float amplitude;
    public float wavelength;
    public float waveSpeed;
    public float xStart;
    public float yStart;
    public bool travelling;
    public Material material;
}
