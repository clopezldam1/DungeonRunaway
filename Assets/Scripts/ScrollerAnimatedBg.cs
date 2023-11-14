using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollerAnimatedBg : MonoBehaviour
{

    [SerializeField] private RawImage img;
    [SerializeField] private float x;

    // Update is called once per frame
    void Update()
    {
        img.uvRect = new Rect(img.uvRect.position + new Vector2(x, img.uvRect.position.y) * Time.deltaTime, img.uvRect.size);

    }
}
