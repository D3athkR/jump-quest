﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MultiplayerCamera : MonoBehaviour {

	public List<Transform> targets;
	public Vector3 offset; 
	public float smoothTime=.5f;
	public float minZoom=40f;
	public float maxZoom=10f;
	public float zoomLimiter=50f;
	private Vector3 velocity; 
	private Camera cam;

	void LateUpdate(){
		if(targets.Count==0)
			return;
			Move();
			Zoom();
	}

	void Zoom(){
		float newZoom=Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance ()/zoomLimiter);
		cam.fieldOfView=Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
	}

	float GetGreatestDistance(){
		var bounds = new Bounds(targets[0].position,Vector3.zero);
		for (int i=0; i<targets.Count; i++){
			bounds.Encapsulate(targets[i].position);
		}
		return bounds.size.y; //change to size.x to get camera to zoom based horizontal x distance between players
	}

	void Move(){
		Vector3 centerPoint=GetCenterPoint();
		Vector3 newPosition=centerPoint + offset;
		transform.position=Vector3.SmoothDamp(transform.position,newPosition,ref velocity,smoothTime);
	}

	Vector3 GetCenterPoint(){
		if(targets.Count==1)
		{
			return targets[0].position;
		}
		var bounds = new Bounds(targets[0].position,Vector3.zero);
		for (int i=0; i<targets.Count; i++){
			bounds.Encapsulate(targets[i].position);
		}
		return bounds.center;
	}


	// Use this for initialization
	void Start () {
		cam=GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
