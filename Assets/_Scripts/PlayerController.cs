using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //public instance variables
    public GameController gameController;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Key"))
        {
            //this._ringSound.Play();
            this.gameController.ScoreValue += 100;
        }
      /*  if (other.gameObject.CompareTag("FireBall"))
        {

            this._fireballSound.Play();
            this.gameController.LivesValue -= 1;
        }

        if (other.gameObject.CompareTag("Heart"))
        {

            this._heartSound.Play();
            this.gameController.LivesValue += 1;
        }*/

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Key")
        {
            Debug.Log("collision");
        }
    }
}
