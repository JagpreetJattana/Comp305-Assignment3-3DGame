﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    //private instance variables
    private int _keyValue;         
    private int _livesValue;
    [SerializeField]
//    private AudioSource _gameOverSound;
    
     


    // Public instance varaibles
//    public int fireballNumber=3;
 //   public EnemyController fireball;
    public Text livesLabel;
    public Text scoreLabel;
    public Text gameOverLabel;

    // public SupermanController superman;
    // public RingController ring;
    //    public Text finalScoreLabel;
    public Text WinGameLabel;
    public Button restartButton;
   // public HeartController heart;
   

    //getters and setters
    public int KeyValue
    {
        get
        {
            return _keyValue;
        }

        set
        {
            _keyValue = value;
            this.scoreLabel.text = "Keys: "+this._keyValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return _livesValue;
        }

        set
        {
            _livesValue = value;
            if (this._livesValue <= 0) {
                this._endGame();
                }
            
            else {
                this.livesLabel.text = "Lives: " + this._livesValue;
            }
            
        }
    }
    // Use this for initialization
    void Start () {
        this._initialize();
       

	
	}
	
    // Update is called once per frame
	void Update () {
	
	}

    //private  methods
    private void _initialize() {
        this.KeyValue = 0;
        this.LivesValue = 5;
        this.gameOverLabel.enabled = false;
        this.WinGameLabel.gameObject.SetActive(false);
        this.restartButton.gameObject.SetActive(false);
    

    }
    //private methods
    //method to end game
    private void _endGame() {
       
        this.gameOverLabel.enabled = true;
      
        this.restartButton.gameObject.SetActive(true);
        this.livesLabel.enabled = false;
        this.scoreLabel.enabled = false;
     //   this.superman.gameObject.SetActive(false);
      //  this.heart.gameObject.SetActive(false);
      //  this.ring.gameObject.SetActive(false);
     //   this._gameOverSound.Play();
      //  this.enemy.gameObject.SetActive(false);

    }

    public void _winGame()
    {
       
        this.livesLabel.gameObject.SetActive(false);
        this.WinGameLabel.gameObject.SetActive(true);
        this.scoreLabel.gameObject.SetActive(false);
        this.restartButton.gameObject.SetActive(true);

    }
    //public methods
    //method to restart the game
    public void RestarButtonClicked() {
        //Application.LoadLevel("Main");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
