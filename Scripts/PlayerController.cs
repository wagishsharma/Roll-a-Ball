using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Text	countText;
	public Text	winText;
	private int count;				
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		setCountText ();
		winText.text = "";

	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float y = 0.0f;
		Vector3 movement = new Vector3 (moveHorizontal,y, moveVertical);
		rb.AddForce (movement *speed);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive(false);
			count = count + 1;
			setCountText ();
			if (count >= 10) {
				winText.text = "You Win!";
			}
		}
		//Destroy(other.gameObject);
	}
	void setCountText()
	{
		countText.text = "Count: " + count.ToString ();
	}
}
