using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_4b_dialogue : MonoBehaviour {
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
                ArtChar1c.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Smeg: Squishy Boots! I need your help to make this planet defendable!";
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
		   ArtChar3a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Squishy Boots";
                Char3speech.text = "I don’t know what that means! But I do know a fun spot to play hide and seek!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 4){
		   ArtChar1c.SetActive(false);
		      ArtChar1d.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 5){
		   ArtChar1d.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Good enough. Where is it?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 6){
		   ArtChar3a.SetActive(false);
		   ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "Right here! See the caves in those cliffs? I love playing in those!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt ==7){
		   ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "This place should work! Squishy Boots, do you have friends who would be willing to come help?";
                Char2name.text = "";
                Char2speech.text = "";
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
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "Sure! All my friends love making new friends! I’ll go get them now! ";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
		  }
       else if (primeInt == 9){
		   ArtChar3b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "Squishy Boots Exits";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 10){
		   ArtChar1a.SetActive(false);
		      ArtChar1d.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "The captain is almost here! I sure hope this plan works…";
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
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "I see them! They’re here! DOWN HERE, CAPTAIN! ON THIS FIELD!";
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
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Nice landing, captain!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		
				else if (primeInt == 13){
					ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Cadet! WHAT IS WRONG WITH THIS PLACE, HOW ARE WE SUPPOSED TO DEFEND THIS PLANET?";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 14){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Uh, UH, Captain!  We have more people to help now!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "And where are they?";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
				else if (primeInt == 16){
			      ArtChar3a.SetActive(true);
					ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "RIGHT HERE";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 17){
				ArtChar2b.SetActive(false);
				ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "What in the seven moons are these things?";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 18){
					ArtChar3a.SetActive(false);
					ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "Squishy!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
					else if (primeInt == 19){
						ArtChar1d.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "(thoughts) uhoh…what am I going to do…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
		}
					else if (primeInt == 20){
						ArtChar2a.SetActive(false);
						ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Do you hear that alarm, Smeg?";
				Char3name.text = " ";
                Char3speech.text = "!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 21){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "OH NO! CAPTAIN, ENEMY FORCES HAVE ARRIVED!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = " ";
                Char3speech.text = "!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 22){
						ArtChar2c.SetActive(false);
						ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Captain";
                Char2speech.text = "Prepare for battle!";
				Char3name.text = " ";
                Char3speech.text = "!";
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
		   ArtChar2a.SetActive(false);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Squishy Boots";
                Char3speech.text = "We have never fought before, but we can try!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 24){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Thank you Squishy Boots!";
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
			ArtChar3b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "The battle ensues";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		 else if (primeInt == 26){
		   ArtChar5.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "Evil Alien";
                Char5speech.text = "TAKE THAT";
        }
		 else if (primeInt == 27){
		   ArtChar1d.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "NO!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 28){
			ArtChar1c.SetActive(false);
			NextScene1Button.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "Evil Alien";
                Char5speech.text = "HAHA Victory is ours!";
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
                Char3speech.text = "OK youuuu got it!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
			else if (primeInt == 31){
				ArtChar3b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "The battle ensues";
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
		   ArtChar1d.SetActive(false);
		   ArtChar1c.SetActive(true);
		    ArtChar5.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "Evil Alien";
                Char5speech.text = "TAKE THAT";
		}
		else if (primeInt == 33){
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "NO!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = " ";
                Char5speech.text = "";
		}
				else if (primeInt == 34){
			ArtChar1c.SetActive(false);
			NextScene1Button.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "Evil Alien";
                Char5speech.text = "HAHA Victory is ours!";
				//scene change
                nextButton.SetActive(false);
                allowSpace = false;
		}

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
			ArtChar2b.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Squishy Boots! Would your people be willing to fight with us in battle?";
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
		ArtChar2b.SetActive(false);
                Char1name.text = "Cadet Smeg";
                Char1speech.text = "Squishy Boots! Your people should find shelter from the battle!";
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
               SceneManager.LoadScene("End_Lose3");
        }
		
		/*
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
		*/
}