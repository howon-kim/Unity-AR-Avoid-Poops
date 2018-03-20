using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIsystem : MonoBehaviour {

    Text health;
	// Use this for initialization
	void Start () {
        health = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        health.text = (" Health " + GameObject.Find("Player").GetComponent<PlayerHealth>().health);
	}
}
