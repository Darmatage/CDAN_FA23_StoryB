
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_r3 : MonoBehaviour {
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
        public GameObject ArtChar3;
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
        ArtChar1b.SetActive(true);
        ArtChar1c.SetActive(false);
        ArtChar2.SetActive(true);
        ArtChar3.SetActive(true);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "J3FF";
                Char1speech.text = "HERE IS THE PERFECT ROBOT 1.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Hello Robot 1, I am Cadet Smeg, I am here because I require assistance. My home planet has been invaded by evil aliens, and my kind is looking for a new planet to call home.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I was wondering if my kind could live here, to stay away from the evil aliens? ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ROBOT 1";
                Char2speech.text = "WHY RUN? YOU CAN TAKE BACK YOUR PLANET WITH OUR HELP.";
        }
       else if (primeInt == 6){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Um, I dont know if we are powerful enough, even together…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "ROBOT 1";
                Char2speech.text = "THAT IS NOT POSSIBLE. WITH OUR TECHNOLOGY WE CAN MAKE YOUR ARMY UNSTOPPABLE.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
               // function Choice1aFunct()
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);

        }

       // after choice 1a
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "J3FF";
                Char2speech.text = "GOODBYE TRAVELER.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
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
               SceneManager.LoadScene("End_Lose1");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene_1");
        }
}