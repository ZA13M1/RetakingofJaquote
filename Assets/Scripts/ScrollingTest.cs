using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingTest : MonoBehaviour
{
    private Camera cam;
    public float speed = .0f;
    private MeshRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _renderer.material.mainTextureOffset = new Vector2(cam.transform.position.x * 0.05f, cam.transform.position.y * 0.05f);
    }
}