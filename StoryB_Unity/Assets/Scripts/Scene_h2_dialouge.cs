
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_h2 : MonoBehaviour {
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
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
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
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
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
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Alright, let’s check out this strange dark planet…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
        ArtChar2b.SetActive(true);
                Char1name.text = "Captain";
                Char1speech.text = "CADET SMEG! THAT IS A BLACK HOLE! DO NOT ENTER!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Captain! What do you mean?!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "No one has ever been inside of a black hole, so technically there COULD be something…";
        }
       else if (primeInt == 6){
                Char1name.text = "Captain";
                Char1speech.text = "… but that’s not something you should chance!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
        ArtChar2a.SetActive(true);
        ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Get back here before you reach the event horizon!";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
               // function Choice1aFunct()
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);

        }

      
      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)


        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose2");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene_1a");
        }
}