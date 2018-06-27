using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	public float JumpForce = 10f;

	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public string currentColor;

	public Color colorCyan;
	public Color colorYellow;
	public Color colorPink;
	public Color colorPurple;

	void Start(){
		
		setRenderColor();

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")||Input.GetMouseButtonDown(0)){
			rb.velocity=Vector2.up*JumpForce;
		}
	}

	void setRenderColor(){
		int index=Random.Range(0,4);

		switch (index){
			case 0:
				currentColor="Cyan";
				sr.color=colorCyan;
				break;
			case 1:
				currentColor="Yellow";
				sr.color=colorYellow;
				break;
			case 2:
				currentColor="Pink";
				sr.color=colorPink;
				break;
			case 3:
				currentColor="Purple";
				sr.color=colorPurple;
				break;
		}
			
	}

	void OnTriggerEnter2D(Collider2D col){

		if(col.tag=="colorChanger"){
			setRenderColor();
			Destroy(col.gameObject);
			return;
		}
		if(col.tag!=currentColor){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

	}
}
