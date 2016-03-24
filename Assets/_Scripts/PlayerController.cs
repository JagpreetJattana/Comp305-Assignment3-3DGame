using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //public instance variables
    public GameController gameController;

    //private instance variables
    private Transform _transform;
    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
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
        if (col.gameObject.CompareTag("Key"))
        {
            
            Destroy(col.gameObject);
            this.gameController.ScoreValue += 10;
        }
        if (col.gameObject.CompareTag("Enemy"))
        {
            this.gameController.LivesValue--;
            this._resetPlayer();
           
        }

        Debug.Log("collision outside");
    }

    //private methods
    private void _resetPlayer() {
        this._transform.position = new Vector3(8f, 16f, -4f);

    }
}
