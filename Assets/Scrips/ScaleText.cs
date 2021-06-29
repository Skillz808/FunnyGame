using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleText : MonoBehaviour
{
    // Time it takes in seconds to shrink from starting scale to target scale.
    public float ShrinkDuration = 5f;

    // The target scale
    public Vector3 TargetScale = Vector3.one * 0f;

    // The starting scale
    Vector3 startScale;

    // T is our interpolant for our linear interpolation.
    float t = 0;

    public GameObject hasDelayOccured;

    void OnEnable()
    {
        // initialize stuff in OnEnable
        startScale = transform.localScale;
        t = 0;
        StartCoroutine(waitForTime());
    }

    void Update()
    {
        if (hasDelayOccured.activeInHierarchy)
        {
            // Divide deltaTime by the duration to stretch out the time it takes for t to go from 0 to 1.
            t += Time.deltaTime / ShrinkDuration;

            // Lerp wants the third parameter to go from 0 to 1 over time. 't' will do that for us.
            Vector3 newScale = Vector3.Lerp(startScale, TargetScale, t);
            transform.localScale = newScale;

            // We're done! We can disable this component to save resources.
            if (t > 1)
            {
                enabled = false;
            }
        }

    }
    public IEnumerator waitForTime()
    {
        yield return new WaitForSeconds(1f);
        hasDelayOccured.SetActive(true);
    }
}