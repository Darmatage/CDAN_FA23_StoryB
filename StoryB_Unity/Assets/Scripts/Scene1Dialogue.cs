using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar1d;
        public GameObject ArtChar2;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtBG1;
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
                Char1speech.text = "Uh uh oh man, the captain sent me out of all the cadets to save our people!! Why did he send me?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Those evil aliens have us right on the ropes, without help or a safe place to go we are done for!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		        ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Uh uh the captain is calling! I better pick it up!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
		   ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Cadet Smeg come in! Come in Cadet Smeg!";
        }
       else if (primeInt == 6){
		        ArtChar1a.SetActive(true);
				ArtChar1c.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I’m here captain!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Good to see you made it out cadet. Do you understand the mission?";
        }
		else if (primeInt == 8){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Uh..yes?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 9){
			 ArtChar2b.SetActive(true);
			 ArtChar2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Since that wasn’t a confident answer I’ll restate your mission.";
        }
		 else if (primeInt == 10){
			 ArtChar2b.SetActive(false);
			 ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Your mission is to find us assistance to defeat the evil aliens. Or find a habitable planet to move our people too to escape the evil aliens.";
        }
		 else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Our people's fate rests in your hands cadet.";
        }
		 else if (primeInt == 12){
			 ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "My hands?! Me??!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 13){
			 ArtChar1a.SetActive(true);
				ArtChar1c.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Uh uh..you got it captain I won’t let you down";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "We’re counting on you cadet.";
        }
		 else if (primeInt == 15){
			 ArtChar2.SetActive(false);
			 ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Phew…";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 16){
			 			 ArtChar1a.SetActive(true);
				ArtChar1b.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Looks like there’s no time to waste, the captain is counting on me!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "Select a planet to visit!";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Then you are no use to me, and must be silenced.";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Come back here! Do not think you can hide from me!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Do not think you can fool me, human. Where will we find him?";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know what you're talking about!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sure, anything you want... just lay off the club.";
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