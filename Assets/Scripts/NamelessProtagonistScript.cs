using UnityEngine;
using System.Collections;

public class NamelessProtagonistScript : CharacterParent {

	// Use this for initialization
	void Start () {
		rectTransform = GetComponent<RectTransform>();
		
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		rectTransform.transform.Translate(x, y, 0f);
	}
}
