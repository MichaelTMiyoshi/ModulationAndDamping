/*
 * Sine
 * 
 * Drawing a Sine wave
 * 
 * Michael T. Miyoshi
 * 
 * (school project)
 * 
 * reference:
 * https://www.codinblack.com/how-to-draw-lines-circles-or-anything-else-using-linerenderer/
 * 
 * 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sine : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public SineWaves sineWaves;     // ScriptableObject
    public float lineWidth = 0.2f;
    public float amplitude;
    public float wavelength;
    public float waveSpeed;
    public float xStart;
    public float yStart;
    public bool travelling;
    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //        lineRenderer.startWidth = lineWidth;
        //        amplitude = 2.0f;
        //        wavelength = 3.0f;
        //        waveSpeed = 4.0f;
        //        xStart = -10.0f;
        //        yStart = 3.0f;
        lineRenderer.startWidth = sineWaves.linewidth;
        amplitude = sineWaves.amplitude;
        wavelength = sineWaves.wavelength;
        waveSpeed = sineWaves.waveSpeed;
        xStart = sineWaves.xStart;
        yStart = sineWaves.yStart;
        travelling = sineWaves.travelling;
    }

    // Update is called once per frame
    void Update()
    {
        DrawSineWave(new Vector3(xStart, yStart, 0), amplitude, wavelength, waveSpeed, travelling);
    }

    void DrawSineWave(Vector3 startPoint, float A, float lambda, float speed, bool travelling)
    {
        lineRenderer.loop = false;
        float x = 0.0f;
        float y;
        float k = 2 * Mathf.PI / lambda;
        float w = k * speed;
        lineRenderer.positionCount = 200;
        for (int i = 0; i < lineRenderer.positionCount; i++)
        {
            x += i * 0.001f;
            if (travelling)
            {
                y = A * Mathf.Sin(k * x + w * Time.time);
            }
            else
            {
                y = A * Mathf.Sin(k * x);
            }
            lineRenderer.SetPosition(i, new Vector3(x, y, 0) + startPoint);
        }
    }
}
