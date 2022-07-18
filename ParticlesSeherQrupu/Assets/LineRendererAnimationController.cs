using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererAnimationController : MonoBehaviour
{
    [SerializeField] private Renderer lineRenderer;

    //[SerializeField] private Material lineMat;

    [Range(0f,1f)]
    [SerializeField] private float animationDelay;
    private void Start()
    {
        StartCoroutine(AnimateLine());
    }

    IEnumerator AnimateLine()
    {
        float lineYOffset = lineRenderer.material.GetTextureOffset("_MainTex").y;

        for(float i = 0; i >= -1; i -= 0.01f)
        {
            lineRenderer.material.SetTextureOffset("_MainTex",new Vector2(i,lineYOffset));

            //lineMat.SetTextureOffset();

            yield return new WaitForSeconds(animationDelay);
        }

        StartCoroutine(AnimateLine());
    }
}
