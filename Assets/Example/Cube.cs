﻿using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    float spinSpeed = 0.1f;
    bool  isSpin = false;


    [JumpCommandRegister("color", "change cube color")]
    Color ChangeColor(Color color) {
        renderer.material.color= color;
        return color;
    }

    [JumpCommandRegister("move", "move to position")]
    Vector3 Move(Vector3 pos) {
        transform.position += pos;
        return transform.position;
    }

    [JumpCommandRegister("move", "move to position")]
    Vector3 Move(Cube cube) {
        transform.position = cube.transform.position;
        return transform.position;
    }   


    [JumpCommandRegister("spin", "begin spin")]
    void Spin() {
        isSpin = true;
    }

    [JumpCommandRegister("stop", "stop spin")]
    void Stop() {
        isSpin = false;
    }

    [JumpCommandRegister("speed", "adjust speed")]
    float AdjustSpeed(float speed) {
        spinSpeed += speed;
        return spinSpeed;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(isSpin) {
            transform.Rotate(new Vector3(0, 0, spinSpeed));
        }	
	}
}
