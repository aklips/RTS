﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {
	//data class
	public bool isExplored = false; //set from pathfinder.cs
	public Waypoint foundFrom;
	const int sizeOfGrid = 10;
	public bool isPlaceable = true;

	//waypoint needs to know it's own position -> calculate position on grid in waypoint script 

	Vector2Int gridPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isExplored) {
			//SetTopColor(exploredFlagColor);
			}
		}

	public Vector2Int GetGridPos() {
		return new Vector2Int(
		Mathf.RoundToInt(transform.position.x / sizeOfGrid),
		Mathf.RoundToInt(transform.position.z / sizeOfGrid));
		}

	public int GetGridSize() {
		return sizeOfGrid;
		}

	//public void SetTopColor(Color color) {
	//	//changes the color of the waypoint cube to sign start, goal and route

	//	MeshRenderer topFaceMeshRenderer = transform.Find("TopFace").GetComponent<MeshRenderer>();
	//	if (topFaceMeshRenderer) {
	//		topFaceMeshRenderer.material.color = color;
	//		}
	//	}
	private void OnMouseOver() {
		if (Input.GetMouseButtonDown(0) == true) {
			if (isPlaceable == true) {
				FindObjectOfType<TowerFactory>().AddTower(this);
				isPlaceable = false;
				}
			}
		}
	}
