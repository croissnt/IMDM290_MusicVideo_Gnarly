using Unity.VisualScripting;
using UnityEngine;

public class sphereManager : MonoBehaviour
{
   
    public GameObject spherePrefab;
    public int totalNumSphere = 20;
    public float radius = 3f;
    GameObject[] spheres;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spheres = new GameObject[totalNumSphere];

        for (int i =0; i < 6; i++)
        {
            
            // spheres start in a circle format 
            float angle =  i * 2 * Mathf.PI / 6;

            Vector3 pos = new Vector3(radius * Mathf.Sin(angle), radius * Mathf.Cos(angle));
            spheres[i*4] = Instantiate(spherePrefab, pos, Quaternion.identity);

            sphereReact scriptRef = spheres[i*4].GetComponent<sphereReact>();
            scriptRef.angleOffset = angle;
        }

        spherePrefab.GetComponent<Renderer>().enabled = false;

    }

    void AddSpheres()
    {
        for (int i = 0; i < totalNumSphere; i++)
        {
            spherePrefab.GetComponent<Renderer>().enabled = true;

            // spheres start in a circle format 
            float angle =  i * 2 * Mathf.PI / totalNumSphere;

            Vector3 pos = new Vector3(radius * Mathf.Sin(angle), radius * Mathf.Cos(angle));
            spheres[i] = Instantiate(spherePrefab, pos, Quaternion.identity);

            sphereReact scriptRef = spheres[i].GetComponent<sphereReact>();
            scriptRef.angleOffset = angle;
            spherePrefab.GetComponent<Renderer>().enabled = false;
        }
    }

    // Update is called once per frame
    bool added = false;

    void Update()
    {
        float time = Time.time;
        ChangeColor();

        if (time >= 32 && !added)
        {
            AddSpheres();
            added = true;
        }
    }

    void ChangeColor()
    {
        
        float minHue = 0.33f;
        float maxHue = 0.95f;
        float hue = Mathf.Lerp(minHue, maxHue, AudioSpectrum.percussion * 5f);

        float minBright = 0f;
        float maxBright = 1f;
        float brightness = Mathf.Lerp(minBright, maxBright, AudioSpectrum.audioAmp * 1f);

        Color color = Color.HSVToRGB(hue, 1f, brightness);

        for (int i = 0; i < totalNumSphere; i++)
        {
            if (spheres[i] != null)
            {
                Renderer sphereRenderer = spheres[i].GetComponent<Renderer>();
                sphereRenderer.material.color = color;
            }
        }

       
    }

    void spherePos(){ //work on later not working...
        //ensure spheres don't overlap visualizer:

        float visualizerRadius = 4f; 

        float distanceFromCenter = transform.position.magnitude;

        if (distanceFromCenter <= visualizerRadius)
        {
        // Push sphere back to edge of visualizer
        transform.position = transform.position.normalized * visualizerRadius;
        }

    }
}
