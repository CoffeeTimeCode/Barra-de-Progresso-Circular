﻿using UnityEngine;
using System.Collections;

public class StatusBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float PegarTamanhoBarra(float _minValor, float maxValor){
		return _minValor / maxValor;
	}

	public int PegarPorcentageBarra(float _minValor, float maxValor){
		return  Mathf.RoundToInt( PegarTamanhoBarra(_minValor,maxValor)*100 );
	}

}
