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
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
        public GameObject nextButton;
     public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
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
                // audioSource.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Uh uh oh man. The Captain sent me, out of all the cadets to save our people!! Why did he send me?";
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
                Char1speech.text = "Uh uh the Captain is calling! I better pick it up!";
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
                Char1speech.text = "I’m here Captain!";
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
                Char2speech.text = "Your mission is to find us assistance to defeat the evil aliens, or find a habitable planet to move our people to in order to escape the evil aliens.";
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
                Char1speech.text = "Uh uh..you got it Captain I won’t let you down";
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
                Char1speech.text = "Looks like there’s no time to waste, the Captain is counting on me!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
		   audioSource.Play();
                Char1name.text = "";
                Char1speech.text = "Select a planet to visit!";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
               // Choice1a.SetActive(true); // function Choice1aFunct()
//Choice1b.SetActive(true); // function Choice1bFunct()
        NextScene1Button.SetActive(true);
		NextScene2Button.SetActive(true);
        NextScene3Button.SetActive(true);
		NextScene4Button.SetActive(true);
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
               SceneManager.LoadScene("Scene_2b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene_r2");
        }
        public void SceneChange3(){
               SceneManager.LoadScene("Scene_5a");
        }
        public void SceneChange4(){
                SceneManager.LoadScene("Scene_h2");
        }
}