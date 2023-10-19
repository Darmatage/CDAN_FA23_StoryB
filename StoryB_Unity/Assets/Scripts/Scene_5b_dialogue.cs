using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_5b_dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
	   public Text Char4name;
       public Text Char4speech;
	   public Text Char5name;
	   public Text Char5speech;
        public GameObject DialogueDisplay;
		
        public GameObject ArtChar1a; //smeg
       public GameObject ArtChar1b;
	   public GameObject ArtChar1c;
	   public GameObject ArtChar1d;
		public GameObject ArtChar2a; // captain
		public GameObject ArtChar2b;
		public GameObject ArtChar2c;
		public GameObject ArtChar3a; // Boots
		public GameObject ArtChar3b;
		public GameObject ArtChar3c;
		public GameObject ArtChar4; // Robot Leader
		public GameObject ArtChar5; // evilalien
		
        public GameObject ArtBG1;

        public GameObject Choice1a; // whether to ask squishies to fight
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
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
		ArtChar3a.SetActive(false);
		ArtChar3b.SetActive(false);
		ArtChar3c.SetActive(false);
		ArtChar4.SetActive(false);
		ArtChar5.SetActive(false);
		
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "Smeg arrives on Squishmuhguy with the robot army";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt ==3){
			ArtChar1b.SetActive(true);
			ArtChar4.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Captain! I have found reinforcements";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Robot 1";
                Char4speech.text = "GREETINGS";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 5){
		   	ArtChar4.SetActive(false);
		   ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "By golly the cadet has done it! Well done lad.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 6){
		   ArtChar3a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "MORE FRIENDS";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt ==7){
		    ArtChar3a.SetActive(false);
			ArtChar1b.SetActive(false);
		   ArtChar1d.SetActive(true);
		   ArtChar2c.SetActive(false);
		   ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Listen up! Our forces now have more technology and supplies!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "It's time to take up arms and take our home back!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
		  }
		else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Crowd";
                Char2speech.text = "*Cheers*";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 10){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Smeg: We’ve done it! We are going to- wait, whats that alarm sound?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 11){
				   ArtChar1d.SetActive(false);
				   ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Captain! the enemies have arrived!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "They found us! No matter, they're in for a nasty surprise! Everyone prepare the defences.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		
			else if (primeInt == 13){
					ArtChar2a.SetActive(false);
					 ArtChar1c.SetActive(false);
					ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cadet Smeg";
                Char2speech.text = "(Gulp) I sure hope we can win this...";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 14){
			ArtChar4.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Robot 1";
                Char4speech.text = "DO NOT FEAR CADET SMEG, OUR ODDS OF WINNING ARE 100%";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 15){
				ArtChar4.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Ok, Th-then lets do this!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 16){
			      ArtChar3a.SetActive(false);
					ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "Battle Ensues";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 17){
				ArtChar2b.SetActive(false);
				ArtChar2a.SetActive(true);
				ArtChar5.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Cadet! The enemy is right on top of me, I need your help!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 18){
					ArtChar3c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "Smeg! This guy is being really mean to me, help!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 19){
				 ArtChar5.SetActive(false);
				ArtChar3c.SetActive(false);
				ArtChar2a.SetActive(false);
				ArtChar1d.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "OH NO!! What am I going to do??";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 23){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Thank you for the assist Cadet! You've saved my life! I'll see you promoted for this!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 24){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh..no... Squishy Boots...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 25){
				NextScene1Button.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "His sacrifice will not be in vain...We will honor him for years-NO. Generations to come.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
			//scene change
                nextButton.SetActive(false);
                allowSpace = false;
        }


       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "Thank you Smeg! You really are my Best Friend";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 31){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh..no... Captain...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "I'm sorry about your friend Smeg... But it looks like we won!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
		}
		else if (primeInt == 33){
				ArtChar1d.SetActive(false);
				ArtChar1b.SetActive(true);
				NextScene1Button.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "We did win. Thank you Captain. Your sacrifice wont be in vain!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = " ";
                Char5speech.text = "";
				//scene change
                nextButton.SetActive(false);
                allowSpace = false;
		}

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
		    ArtChar2c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I'm coming Captain!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 23; //come back to
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			   		ArtChar3a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I'm coming Squishy Boots!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Win1");
        }
		
		/*
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
		*/
}