using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_5a_dialogue : MonoBehaviour {
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
        public GameObject ArtBG1; //usa
		public GameObject ArtBG2; // area 51
		public GameObject ArtBG3; //black
		public GameObject ArtBG4; //pyramid giza
		public GameObject ArtBG5; //pyramid int
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
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
		
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
		ArtBG5.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
                Char1speech.text = "This planet is huge!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "But… while I was landing, I saw an abundance of h2o, and there appears to be none where I landed…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = " Should I stay here? Or explore this planet a bit more? ";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Target has been spotted.";
        }
	   else if (primeInt == 21){
		    ArtChar1a.SetActive(false);
		   ArtChar1d.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Huh? Who was that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
	    else if (primeInt == 22){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Hello? Is this your planet? Can you help me?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 23){
		    ArtChar1d.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Please we need–";
                Char2name.text = "";
                Char2speech.text = "";
        }
	   else if (primeInt == 24){
		    ArtBG1.SetActive(false);
		    ArtBG3.SetActive(true);
			ArtChar1a.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
	    else if (primeInt == 25){
		    ArtBG3.SetActive(false);
		    ArtBG2.SetActive(true);
		   ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 26){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "What...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 27){
                Char1name.text = "Cadet Smeg";
				ArtChar1c.SetActive(false);
		   ArtChar1d.SetActive(true);
                Char1speech.text = "Where am I? HELP!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 28){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = " I need to call the captain!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 29){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = " ...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 30){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Oh no… where’s my stuff?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 31){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "HELLO!! HELP! WHERE AM I!";
                Char2name.text = "";
                Char2speech.text = "";
        }
	    else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "The subject is awake";
        }
		else if (primeInt == 33){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "What? Who said that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "None of your concern.";
        }
		else if (primeInt == 35){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Where am I?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 36){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "Welcome to Area 51. Prepare to spend the rest of your life here.";
        }
		else if (primeInt == 37){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "What are you going to do to me?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 38){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "That information is classified.";
				//Go to next scene
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		
		
		
       // after choice 1b
       else if (primeInt == 49){
		    ArtBG1.SetActive(false);
		    ArtBG4.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Woah… These buildings are…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 50 ){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Surprisingly.. Familiar?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 51 ){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "There’s no way these triangular structures weren’t built by our kind… I should look inside…";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 52 ){
			 ArtBG4.SetActive(false);
		    ArtBG5.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = " It sure is dusty in here, gross! I don’t think anyone’s been here in centuries.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		    else if (primeInt == 53 ){
	
                Char1name.text = "Cadet Smeg";
                Char1speech.text = " What’s that over there? Is that...";
                Char2name.text = "";
                Char2speech.text = "";
        }
			else if (primeInt == 54 ){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Wow! This is ancient technology! Communication devices, resources… and weapons.";
                Char2name.text = "";
                Char2speech.text = "";
        }
			else if (primeInt == 55 ){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Maybe.. Just maybe.. We could stay here instead!";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice3bFunct()	
        }
		
		
		//after choice 2a
       else if (primeInt == 60){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I bet we could all fit in here!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 61){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "It's perfect!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==62){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I better call the captain!";
                Char2name.text = "";
                Char2speech.text = "";
				//Go to next scene
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		
		//after choice 2b
       else if (primeInt == 70){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Yeah! Yeah, I better call the captain!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 71){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "We're getting our planet back!";
                Char2name.text = "";
                Char2speech.text = "";
				//Go to next scene
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
        }
		

		
      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I mean, it wouldn’t hurt to look around. This is a pretty big field after all… ";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			 ArtChar1a.SetActive(false);
			 ArtChar1b.SetActive(true);
			   Char1name.text = "Cadet Smeg";
                Char1speech.text = "Off I go!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 48;
			  	Choice1a.SetActive(false);
				Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        } 
		
		public void Choice2aFunct(){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Yeah, that's a good idea!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice2bFunct(){
	            allowSpace = true;
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Or... we could use all this technology to fight back!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 69;
			  	Choice2a.SetActive(false);
				Choice2b.SetActive(false);
                nextButton.SetActive(true);

        } 






        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose4_Area51");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Win2_Giza");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("End_Lose5_Earth");
        }
}