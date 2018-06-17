using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour {

    public List<string> endingsList = new List<string>();
    public Text ending;
    public string endForThisGame;
    public void PopulateEndings()
    {
        string end1 = "Schools alarm system goes off and voice in speakers shouts: Skolen er i brand! Hold dig rolig og lad bygningen være væk! (The school is on fire! Keep calm and let the building be gone leave the building!)Teachers stood up and left the room.Congratulations!You will have reexamination, do prepare for it this time!";
        string end2 = "You look stressfully at the clock. The time has come! Teachers notice your desperate look. Their patience has run out. As miss Poppy is about to write FAIL to your grading paper, she and both other teachers receive SMS on their phones. It seems you are a lucky student!says Mrs Poppy.The lockout has started, so we can not continue this examination.The school will contact you with new dates.Teachers stood up and left the room. Congratulations!You will have reexamination, do prepare for it this time!";
        string end3 = "The time has come. If the fortune teller is right then now your luck has to be at its peak and your biggest problem should disappear. And at this point, the shower of meteors started to destroy the school building and the teachers make you hide in the basement. Congratulations!You will probably still have reexamination, so do prepare for it this time!";
        string end4 = "Out of nowhere, your saviour comes. The long nights of praying to all gods you know from Satan, Zeus to the Christian God. The flawless Unicorn comes straight through the window, takes you to the outside and gives you a blessing. Teachers stunned by the beauty of the unicorn let you stay with it and take pictures.Congratulations!But you still will have reexamination, so do prepare for it this time!";
        string end5 = "Out of nowhere, the sky gets dark as the ebony veil. And after few seconds the rainbow beam so enormous and colourful strikes at you and the teachers. None of you is able to see and you have to go to the hospital. Luckily, you have destroyed the evidence by taking your notebook with you, so you have to take reexamination. Congratulations!";
        string end6 = "You hear strange sounds outside. Growls and howls and you realize the danger comes closer. Big mutated zombie is devouring the other students waiting for examination. Teachers and you in a horrible terror try to hide yourselves and wait until the creature is captured by the government. Unfortunately, that means you still have to take the exam but you have been pardoned from the one you have taken. Congratulations!";
        string end7 = "You hope for a save and it comes! You wanted to have luck so you bought the lottery ticket. And believe it or not, you won! In a second there is a TV camera with a redactor congratulating you to the fact, you have won the Jackpot. Yeah sure now you can buy the whole school, but still, you will have to take reexamination since the reporter takes you to their studio to ask how do you feel. But congratulations!";
        string end8 = "And the time is now. Schools alarm goes off. It's time to evacuate! You are so happy and refiled. Thanks to Random Allan evacuation training is starting earlier. The teachers sight but get up and start leaving the classroom.It seems we will continue some other time,says Mr Noruas.Yesss!Congratulations!But be prepared for the reexamination!";
        string end9 = "You hear screams outside but you don't dare to look one more time to the window. The teachers hear them too. Mr Pony gets up and goes to one of the windows. You can see the shock on his face: We have to get to higher floors. NOW!You and all teachers get to schools roof and you see that a gigantic wave is heading your way.This is the end and you know it. You just spend your last day in the exam you had no chances to pass. You go to the closest wall and sit by its side.Mrs Poppy just cries, Mr Noruas prays to the devil, so that doesn't take his soul, and Mrs Pony runs around screaming. This is your end. The wave comes closer. You feel the whole building shaking, like a jelly. The sound of deadly water and screams of helpless people will make you go mad before you die. And then the tsunami strikes. The building bends and you hold to the only pipe. The teachers have washed away, no gods helped them. And then… it was over. You were lucky to be behind this thin wall, holding to the pipe. The fortune teller was written. Congratulations! As soon as you start to celebrate an SMS arrives.Your examination is postponed, we will let you know the new date, time and room,said Mr Noruas.";
        endingsList.Add(end1);
        endingsList.Add(end2);
        endingsList.Add(end3);
        endingsList.Add(end4);
        endingsList.Add(end5);
        endingsList.Add(end6);
        endingsList.Add(end7);
        endingsList.Add(end8);
        endingsList.Add(end9);
    }
    public void PickAndDisplayEnding()
    {
        PopulateEndings();
        int number = UnityEngine.Random.Range(0, endingsList.Count);
        endForThisGame = endingsList[number];

    }
    // Use this for initialization
    void Start () {
        PickAndDisplayEnding();
        ending.text = endForThisGame;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
