using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_3b : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
	   public GameObject ArtChar1c;
	   public GameObject ArtChar1d;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
		public GameObject ArtChar2a;
		public GameObject ArtChar2b;
		public GameObject ArtChar2c;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       Next();
                }
        }
   }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Come in captain! I have found a suitable planet.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
		   ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Well done Cadet! Give us your location and we will travel to the planet.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		      ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Is it defendable?";
        }
       else if (primeInt == 5){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Uh...Not Exactly?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "And what EXACTLY is that supposed to mean?!";
        }
       else if (primeInt ==7){
		   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "The planet is squishy and very strange, but there is food here!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
		   ArtChar2b.SetActive(false);
		   ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "How do you expect us to win a war with no way to defend ourselves?!";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "You send our forces to this planet and I’ll find more help!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "CADET, YOUR GOAL WAS TO-";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "This place is really defendable! You’ll see";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "IT BETTER BE OR IT’LL BE YOU WE FEED TO THE ENEMY!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Don’t worry Captain!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Don’t worry Captain!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}