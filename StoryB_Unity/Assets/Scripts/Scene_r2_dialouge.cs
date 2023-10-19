
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_r2 : MonoBehaviour {
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
        public GameObject ArtChar2;
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
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar2.SetActive(false);
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
                ArtChar1b.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Hmm, not much to be seen other than those tall structures over there, I wonder where I could find some plants.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
				StartCoroutine(TypeText(Char2speech, "HELLO TRAVELER!"));
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "AAH! Who are you?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "J3FF";
				StartCoroutine(TypeText(Char2speech, "I AM ROBOT J3FF, BUT YOU CAN CALL ME J3FF."));
        }
       else if (primeInt == 6){
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Well, hi there J3ff, I didn’t realize that there was life on this planet.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "J3FF";
				StartCoroutine(TypeText(Char2speech, "LIFE? THERE IS NO LIFE ON THIS PLANET, ONLY ROBOTS."));
		}
       else if (primeInt == 8){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cadet Smeg";
                Char2speech.text = "No life? That would make it very difficult to live here then. Do you have a captain I can talk to?";
		}
       else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "J3FF";
                StartCoroutine(TypeText(Char2speech, "YES. I CAN TAKE YOU TO ROBOT 1. BUT ONLY IF YOU HAVE A WORTHY GIFT."));
		}
       else if (primeInt ==10){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Um, maybe I should think about this actually, I wouldn’t want to waste the captain’s time on a lifeless planet!";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
	   		 
			   if(GameHandler.hasGumball == true) {
				   NextScene1Button.SetActive(true);  
			   }
	   }

        

       // after choice 1a
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "J3FF";
				StartCoroutine(TypeText(Char2speech, "GOODBYE TRAVELER."));
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

       

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Sorry J3FF, I actually have to go… bye!";
                Char2name.text = "";
                Char2speech.text = "";
                NextScene1Button.SetActive(false);
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_r3");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene_1a");
        }
		        IEnumerator TypeText(Text target, string fullText){
                float delay = 0.01f;
                nextButton.SetActive(false);
                allowSpace = false;
                for (int i = 0; i < fullText.Length; i++){
                        string currentText = fullText.Substring(0,i);
                        target.text = currentText;
                        yield return new WaitForSeconds(delay);
                }
                nextButton.SetActive(true);
                allowSpace = true;
        }
}