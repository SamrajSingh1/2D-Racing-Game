using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {
	public GameObject []cars;
	int carNo;
	float timer;
	public float delayTime = 0.5f;
	// Use this for initialization
	void Start () {
		timer = delayTime;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			Vector3 carPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);
			carNo = Random.Range(0, 4);
			Instantiate(cars[carNo], carPos, transform.rotation);
			timer = delayTime;
		}
	}
}
