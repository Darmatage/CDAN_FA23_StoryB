
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_2b : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
		
        public GameObject ArtChar1a; // smeg nervous
        public GameObject ArtChar1b; // smeg confused
        public GameObject ArtChar1c; //smeg relieved
        public GameObject ArtChar1d; // smeg scared
		
        public GameObject ArtChar2a; // squishboots happy
        public GameObject ArtChar2b; // normal
        public GameObject ArtChar2c; // confused

        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
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
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
                Char1speech.text = "Whoa this place is so bright and colorful! A completely different vibe than my world. But…there's something weird about this place… seems awfully squishy?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
		   ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "IT SURE IS";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		   ArtChar1a.SetActive(false);
		   ArtChar1d.SetActive(true);
		   ArtChar2a.SetActive(false);
		   ArtChar2c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "OH MY GOSH PLEASE DON'T HURT ME";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "I’m not gonna hurt you friend! I saw the ship come down and I came to say Hi!";
        }
       else if (primeInt == 6){
		     ArtChar1d.SetActive(false);
		     ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Thank goodness...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
			 ArtChar1c.SetActive(false);
		     ArtChar1b.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Who are you?";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 8){
		     ArtChar2c.SetActive(false);
		     ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "I’m Squishy Boots! What can I do for you, friend?";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(): Trust Squishy
                Choice1b.SetActive(true); // function Choice1bFunct(): Lie to Squishy
        }
		
		
		// after choice 1a
       else if (primeInt == 20){
			 ArtChar2a.SetActive(false);
		     ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "That's so sad! Well of course your people could come here. The more friends the merrier.";
        }
       else if (primeInt == 21){
		    ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh that was easy, don’t you guys have a leader or something?";
                Char2name.text = "";
                Char2speech.text = "";
        }
    else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "Uh, I don’t think so. We all just kinda walk around and say “hi” to each other!";
        }
	else if (primeInt == 23){
			ArtChar1c.SetActive(false);
		    ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh no, there's no army? That's not good…do you guys have food?";
                Char2name.text = "";
                Char2speech.text = "";
        }
	else if (primeInt == 24){
		     ArtChar2c.SetActive(false);
		     ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "Of course we do! Here!";
				GameHandler.hasGumball = true;
        }
	else if (primeInt == 25){
			ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh thanks. Looks like a gumball. ";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 39;
        }

		
		
       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "Well, normally we like to help people who are in desperate need, but since you’re fine, I will say good day and see if I can find someone who needs me.";
        }
		else if (primeInt == 31){
			 ArtChar1b.SetActive(false);
		     ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh! Wait. Sorry. We actually have a desperate need to find a new home! Our planet is being attacked!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 32){
			 ArtChar2a.SetActive(false);
		     ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "You lied to me? Not cool.";
        }
		else if (primeInt == 33){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Sorry. Sorry. Can my people still come here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "Hmm. Well, we don’t turn people away who need help. Up to you.";
			primeInt = 39;
        }
		
		
		else if (primeInt == 40){
			ArtChar1a.SetActive(false);
		    ArtChar1b.SetActive(true);
			ArtChar2c.SetActive(false);
		    ArtChar2b.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I Guess I can call the captain and tell him we can come here? Or maybe I should keep looking at other planets?";
                Char2name.text = "";
                Char2speech.text = "";
        }
     else if (primeInt == 41){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice1aFunct(): return to ship
                Choice2b.SetActive(true); // function Choice1bFunct(): call captain
        }
		
		
		
		
		// after choice 2a
		else if (primeInt == 50){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I’ll hopefully see you soon.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 51){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "OK GOODBYE FRIEND";
				//Go to next scene
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

		
		
		
		// after choice 2b
		else if (primeInt == 60){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "We should definitely move here!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 61){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Squishy Boots";
                Char2speech.text = "The captain will be so pleased!";
				//Go to next scene
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

		
		

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
			ArtChar1b.SetActive(false);
		    ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh yes, My home planet is being attacked by an evil alien empire! I’ve been sent to find sanctuary for our planet and our army, We need your planets help!";
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
                Char1speech.text = "Oh, just exploring the galaxy. Nothing much. What do you do around here for fun?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void Choice2aFunct(){
			ArtChar1c.SetActive(false);
		    ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I better find more reinforcements. Thank you for your help squishy boots!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
			GameHandler.hasCalledCaptain = true;
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "This place seems great! I will call my Captain. ";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		
		
		
        public void SceneChange1(){
               SceneManager.LoadScene("Scene_1a"); // return to ship
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene_3b"); // 
        }
}