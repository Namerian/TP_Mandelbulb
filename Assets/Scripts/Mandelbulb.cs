using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mandelbulb : MonoBehaviour {

    [SerializeField]
    private ComputeShader _shader;

    private RenderTexture _bufferTexture;
    private int _kernelIndex;

	// Use this for initialization
	void Start () {
        _kernelIndex = _shader.FindKernel("CSMain");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
