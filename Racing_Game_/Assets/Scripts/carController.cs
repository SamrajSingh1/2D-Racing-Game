using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {
	public float carSpeed;
	Vector3 position;
	public UI_Manager ui;
	public AudioManager am;
	// Use this for initialization
	void Start () {
		am.carSound.Play();
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis("Horizontal") * carSpeed*Time.deltaTime;
		position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
		transform.position = position;
	}
	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			
			Destroy(gameObject);
			ui.gameOverAx();
			am.carSound.Stop();

		}
	}
	
}
