////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;
////using UnityEngine.UI;


////public class QuestionManager : MonoBehaviour {

////    private TeachersClass teacher;
////    public string[] questionsForThisGame;
////    //public int arraysplace = 0;
////    public void PickAllQuestionsForThisGame()
////    {

////        for (int i = 0; i < 10; i++)
////        {
////            int number = Random.Range(0, 49);
////            string question1 = teacher.mrNoruasQuestions[number];
////            //for(arraysplace; arraysplace <3; arraysplace++)
////            questionsForThisGame[i] = question1;
////        }
////        //for (int i = 10; i < 20; i++)
////        //{
////        //    int number = Random.Range(0, teacher.mrNoruasQuestions.Length - 1);
////        //    string question2 = teacher.mrPonnyRainbowQuestions[number];
////        //    questionsForThisGame[i] = question2;
////        //}

////        //string question3 = teacher.mrsPoppysQuestions[number];


////    }
////    public Text questionsText;

////	// Use this for initialization
////	void Start () {
////        PickAllQuestionsForThisGame();
////        questionsText.text = questionsForThisGame[0];
////    }

////	// Update is called once per frame
////	void Update () {

////	}
////}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class QuestionManager : MonoBehaviour
//{

//    public string teacherName;
//    public string[] mrPonnyRainbowQuestions = { "What is TCP?", "What is UDP?", "What is SOAP?", "What is a kernel thread?", "What is user thread?", "What is Mutex?", "What is semaphore?", "How does First come- First served scheduling algorithm work?", "How does Preemptive Short Job First scheduling algorithm work?", "How does Non-preemptive Short Job First scheduling algorithm work?", "How does Priority scheduling algorithm work?", "How does Round Robin scheduling algorithm work?", "What is OSI model?", "Transmission Control Protocol/IP Model?", "How does 3-way handshake work?", "What is network hardware and servers?", "What is Subnetting?", "What are Network types?", "What is Broadcast?", "What is Tor?", "What is Proxy pattern?", "What is VPN?", "What is VLAN?", "What is HTTP?", "How does HTTP GET work?", "How does HTTP POST work?", "How does HTTP HEAD work?", "What is Telnet?", "What is TCP/IP protocol?", "What is SSH?", "What is encryption?", "What is hashing?", "What is salting? ", "What is PGP?", "What is GPG?", "What are SQL injections?", "What is thread safety? ", "How you ensure thread safety? ", "What is brute forcing?", "What are honeypots?", "What is port scanning? ", "What is ACID?", "What is normalization?", "What are normalization forms?", "What is a Database? ", "Why do we normalize the database? ", "What is CPU?", "What is motherboard" };
//    public string[] mrsPoppysQuestions = { "What is an artifact?", "What is Object model?", "What is Domain model?", "What is Design Class Diagram?", "What is difference between Object and Domain model?", "What is Sequence Diagram?", "What Is Systems Sequence Diagram?", "How can you assure artifacts quality?", "How can you assure traceability?", "What is the difference between Use Case and User story?", "What is the difference between persona and actor?", "What is UML?", "What is Use Case?", "What is persona?", "What is scenario?", "What is Business model?", "What is Business case?", "What is FURPS+?", "What is a User Story?", "What is class diagram?", "What is operation contract?", "What is Scrum?", "What is Maintenance phase?", "What is Scrum Master?", "What is Product Owner?", "What is Sprint?", "What is traceability?", "What kind of methodologies do you know?", "What is security by design?", "What is the difference between Sprint backlog and Product backlog?", "What is Sprint Planning?", "What is Product Backlog?", "What is daily scrum meeting?", "What is review meeting?", "What is retrospective meeting?", "What is iterative approach?", "What is agile approach?", "What is process model?", "What is design?", "What is architecture?", "What is case diagram? ", "What is waterfall?", "What are requirements?", "What are goals?", "What is start up?", "What is High level design phase?", "What is Low level design phase?", "What is Deployment phase?", "What is Development phase?", "What is Testing phase?", "What is contract?", "What is risk analysis?" };
//    public string[] mrNoruasQuestions = { "What is Asp.Net?", "What is MVC model?", "What is WCF?", "What is WebApi?", "What is Razor?", "What is socket?", "What are threads?", "What is thread life cycle?", "What is session?", "What is HTML?", "What is JavaScript?", "What is Fiddler?", "What is JSON?", "What is WSDL?", "What is XML?", "What is a return type?", "What is inheritance?", "What is an object?", "What is C#?", "What are methods?", "What is static?", "What is return type?", "What are parameters?", "What is a class?", "What is abstract?", "What is Sprint?", "What is enum?", "What is a bool/boolean?", "What are operators?", "What are data types?", "What is overload?", "What is override?", "What is an array?", "What is a list?", "What is a dictionary?", "What are loops?", "What are the different types of loops?", "What is a constructor?", "How does If loop work?", "How does While loop work?", "How does Foreach loop work?", "How does For loop work?", "What is a property?", "What is an interface?", "What is a delegate?", "What is polymorphism?", "What is a repository?", "What is LinQ", "What is Lambda?", "What are events?", "What is a binary tree?", "What is an algorithm?" };


//    public string[] questionsForThisGame;
//    public Text question;

//    public string[] PickQuestionsForThisGame(string[] teachersarray)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            int number1 = Random.Range(0, teachersarray.Length - 1);
//            string question1 = mrPonnyRainbowQuestions[number1];
//            questionsForThisGame[i]=question1;
//            questionsForThisGame.ToString();
//        }
//    }

//    // Use this for initialization
//    void Start()
//    {
//        string[] ThisGamesMrPonnyRainbowQuestions = PickAllQuestionsForThisGame(mrPonnyRainbowQuestions);
//        question.text = questionsForThisGame[0];
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuestionManager : MonoBehaviour
{

    public string teacherName;
    public string[] mrPonnyRainbowQuestions = { "What is TCP?", "What is UDP?", "What is SOAP?", "What is a kernel thread?", "What is user thread?", "What is Mutex?", "What is semaphore?", "How does First come- First served scheduling algorithm work?", "How does Preemptive Short Job First scheduling algorithm work?", "How does Non-preemptive Short Job First scheduling algorithm work?", "How does Priority scheduling algorithm work?", "How does Round Robin scheduling algorithm work?", "What is OSI model?", "Transmission Control Protocol/IP Model?", "How does 3-way handshake work?", "What is network hardware and servers?", "What is Subnetting?", "What are Network types?", "What is Broadcast?", "What is Tor?", "What is Proxy pattern?", "What is VPN?", "What is VLAN?", "What is HTTP?", "How does HTTP GET work?", "How does HTTP POST work?", "How does HTTP HEAD work?", "What is Telnet?", "What is TCP/IP protocol?", "What is SSH?", "What is encryption?", "What is hashing?", "What is salting? ", "What is PGP?", "What is GPG?", "What are SQL injections?", "What is thread safety? ", "How you ensure thread safety? ", "What is brute forcing?", "What are honeypots?", "What is port scanning? ", "What is ACID?", "What is normalization?", "What are normalization forms?", "What is a Database? ", "Why do we normalize the database? ", "What is CPU?", "What is motherboard" };
    public string[] mrsPoppysQuestions = { "What is an artifact?", "What is Object model?", "What is Domain model?", "What is Design Class Diagram?", "What is difference between Object and Domain model?", "What is Sequence Diagram?", "What Is Systems Sequence Diagram?", "How can you assure artifacts quality?", "How can you assure traceability?", "What is the difference between Use Case and User story?", "What is the difference between persona and actor?", "What is UML?", "What is Use Case?", "What is persona?", "What is scenario?", "What is Business model?", "What is Business case?", "What is FURPS+?", "What is a User Story?", "What is class diagram?", "What is operation contract?", "What is Scrum?", "What is Maintenance phase?", "What is Scrum Master?", "What is Product Owner?", "What is Sprint?", "What is traceability?", "What kind of methodologies do you know?", "What is security by design?", "What is the difference between Sprint backlog and Product backlog?", "What is Sprint Planning?", "What is Product Backlog?", "What is daily scrum meeting?", "What is review meeting?", "What is retrospective meeting?", "What is iterative approach?", "What is agile approach?", "What is process model?", "What is design?", "What is architecture?", "What is case diagram? ", "What is waterfall?", "What are requirements?", "What are goals?", "What is start up?", "What is High level design phase?", "What is Low level design phase?", "What is Deployment phase?", "What is Development phase?", "What is Testing phase?", "What is contract?", "What is risk analysis?" };
    public string[] mrNoruasQuestions = { "What is Asp.Net?", "What is MVC model?", "What is WCF?", "What is WebApi?", "What is Razor?", "What is socket?", "What are threads?", "What is thread life cycle?", "What is session?", "What is HTML?", "What is JavaScript?", "What is Fiddler?", "What is JSON?", "What is WSDL?", "What is XML?", "What is a return type?", "What is inheritance?", "What is an object?", "What is C#?", "What are methods?", "What is static?", "What is return type?", "What are parameters?", "What is a class?", "What is abstract?", "What is Sprint?", "What is enum?", "What is a bool/boolean?", "What are operators?", "What are data types?", "What is overload?", "What is override?", "What is an array?", "What is a list?", "What is a dictionary?", "What are loops?", "What are the different types of loops?", "What is a constructor?", "How does If loop work?", "How does While loop work?", "How does Foreach loop work?", "How does For loop work?", "What is a property?", "What is an interface?", "What is a delegate?", "What is polymorphism?", "What is a repository?", "What is LinQ", "What is Lambda?", "What are events?", "What is a binary tree?", "What is an algorithm?" };

    //public List<string> endingsList = new List<string>();

    static public List<string> questionsForThisGameFromNoruas = new List<string>();
    static public List<string> questionsForThisGameFromPoppy = new List<string>();
    static public List<string> questionsForThisGameFromPonny = new List<string>();
    static public List<string> allQuestions = new List<string>();
    public Text question;
    //public Text ending;
    public int questionIndex = 0;
    //public string endForThisGame;

    public Text procentage;
    public Slider susspicionBar;
    public Image susspicionBarsFill;
    public Color orangeColor;
    public Color redColor = new Color();

    public Text time;
    public float timeAmount;

    //public void PopulateEndings()
    //{
    //    string end1 = "Schools alarm system goes off and voice in speakers shouts: Skolen er i brand! Hold dig rolig og lad bygningen være væk! (The school is on fire! Keep calm and let the building be gone leave the building!)Teachers stood up and left the room.Congratulations!You will have reexamination, do prepare for it this time!";
    //    string end2 = "You look stressfully at the clock. The time has come! Teachers notice your desperate look. Their patience has run out. As miss Poppy is about to write FAIL to your grading paper, she and both other teachers receive SMS on their phones. It seems you are a lucky student!says Mrs Poppy.The lockout has started, so we can not continue this examination.The school will contact you with new dates.Teachers stood up and left the room. Congratulations!You will have reexamination, do prepare for it this time!";
    //    string end3 = "The time has come. If the fortune teller is right then now your luck has to be at its peak and your biggest problem should disappear. And at this point, the shower of meteors started to destroy the school building and the teachers make you hide in the basement. Congratulations!You will probably still have reexamination, so do prepare for it this time!";
    //    string end4 = "Out of nowhere, your saviour comes. The long nights of praying to all gods you know from Satan, Zeus to the Christian God. The flawless Unicorn comes straight through the window, takes you to the outside and gives you a blessing. Teachers stunned by the beauty of the unicorn let you stay with it and take pictures.Congratulations!But you still will have reexamination, so do prepare for it this time!";
    //    string end5 = "Out of nowhere, the sky gets dark as the ebony veil. And after few seconds the rainbow beam so enormous and colourful strikes at you and the teachers. None of you is able to see and you have to go to the hospital. Luckily, you have destroyed the evidence by taking your notebook with you, so you have to take reexamination. Congratulations!";
    //    string end6 = "You hear strange sounds outside. Growls and howls and you realize the danger comes closer. Big mutated zombie is devouring the other students waiting for examination. Teachers and you in a horrible terror try to hide yourselves and wait until the creature is captured by the government. Unfortunately, that means you still have to take the exam but you have been pardoned from the one you have taken. Congratulations!";
    //    string end7 = "You hope for a save and it comes! You wanted to have luck so you bought the lottery ticket. And believe it or not, you won! In a second there is a TV camera with a redactor congratulating you to the fact, you have won the Jackpot. Yeah sure now you can buy the whole school, but still, you will have to take reexamination since the reporter takes you to their studio to ask how do you feel. But congratulations!";
    //    string end8 = "And the time is now. Schools alarm goes off. It's time to evacuate! You are so happy and refiled. Thanks to Random Allan evacuation training is starting earlier. The teachers sight but get up and start leaving the classroom.It seems we will continue some other time,says Mr Noruas.Yesss!Congratulations!But be prepared for the reexamination!";
    //    string end9 = "You hear screams outside but you don't dare to look one more time to the window. The teachers hear them too. Mr Pony gets up and goes to one of the windows. You can see the shock on his face: We have to get to higher floors. NOW!You and all teachers get to schools roof and you see that a gigantic wave is heading your way.This is the end and you know it. You just spend your last day in the exam you had no chances to pass. You go to the closest wall and sit by its side.Mrs Poppy just cries, Mr Noruas prays to the devil, so that doesn't take his soul, and Mrs Pony runs around screaming. This is your end. The wave comes closer. You feel the whole building shaking, like a jelly. The sound of deadly water and screams of helpless people will make you go mad before you die. And then the tsunami strikes. The building bends and you hold to the only pipe. The teachers have washed away, no gods helped them. And then… it was over. You were lucky to be behind this thin wall, holding to the pipe. The fortune teller was written. Congratulations! As soon as you start to celebrate an SMS arrives.Your examination is postponed, we will let you know the new date, time and room,said Mr Noruas.";
    //    endingsList.Add(end1);
    //    endingsList.Add(end2);
    //    endingsList.Add(end3);
    //    endingsList.Add(end4);
    //    endingsList.Add(end5);
    //    endingsList.Add(end6);
    //    endingsList.Add(end7);
    //    endingsList.Add(end8);
    //    endingsList.Add(end9);
    //}
    public void PickAllQuestionsFromMrPonnyRainbow()
    {
        for (int i = 0; i < 10; i++)
        {
            int number = UnityEngine.Random.Range(0, mrPonnyRainbowQuestions.Length - 1);
            string question = mrPonnyRainbowQuestions[number];
            questionsForThisGameFromPonny.Add(question);
        }
    }

    public void PickAllQuestionsFromMrsPoppy()
    {
        for (int i = 0; i < 10; i++)
        {
            int number = UnityEngine.Random.Range(0, mrsPoppysQuestions.Length - 1);
            string question = mrsPoppysQuestions[number];
            questionsForThisGameFromPoppy.Add(question);
        }
    }

    public void PickAllQuestionsFromMrNoruas()
    {
        for (int i = 0; i < 10; i++)
        {
            int number = UnityEngine.Random.Range(0, mrNoruasQuestions.Length - 1);
            string question = mrNoruasQuestions[UnityEngine.Random.Range(0, mrNoruasQuestions.Length - 1)];
            questionsForThisGameFromNoruas.Add(question);
        }
    }

    public void PickAllQuestionsForThisGame()
    {
        PickAllQuestionsFromMrPonnyRainbow();
        PickAllQuestionsFromMrsPoppy();
        PickAllQuestionsFromMrNoruas();

        for (int i = 0; i < 10; i++)
        {
            allQuestions.Add(questionsForThisGameFromPonny[i]);
            allQuestions.Add(questionsForThisGameFromNoruas[i]);
            allQuestions.Add(questionsForThisGameFromPoppy[i]);
        }
    }

    //public void PickAndDisplayEnding()
    //{
    //    PopulateEndings();
    //    int number = UnityEngine.Random.Range(0, endingsList.Count);
    //    endForThisGame = endingsList[number];
        
    //}
    // Use this for initialization
    void Start()
    {
        PickAllQuestionsForThisGame();
        //PickAndDisplayEnding();
        
        question.text = allQuestions[questionIndex];

    }

    // Update is called once per frame
    void Update()
    {
        procentage.text = susspicionBar.value + "%";
        question.text = allQuestions[questionIndex];

        if(susspicionBar.value == 100)
        {
            SceneManager.LoadScene("LostEndScene");
            Debug.Log("Susspicion is 100%");
            Debug.Log("Game over :)");
            
        }
        else if(susspicionBar.value > 49 && susspicionBar.value < 89)
        {
            Debug.Log("Susspicion is 50%");
            susspicionBarsFill.color = orangeColor;


        }
        else if (susspicionBar.value > 88)
        {
            Debug.Log("Susspicion is 89%");
            susspicionBarsFill.color = redColor;
        }
    }

    public void PressRepeat()
    {
        if (questionIndex < 29)
        {
            questionIndex++;
            question.text = allQuestions[questionIndex];
            susspicionBar.value += 10;
        }
        else
        {
            SceneManager.LoadScene("WinEndScene");
            Debug.Log("Game over :)");
        }
        
    }
    public void PressLaugh()
    {
        if (questionIndex < 29)
        {
            questionIndex++;
            question.text = allQuestions[questionIndex];
            susspicionBar.value += 1;
        }
        else
        {
            SceneManager.LoadScene("WinEndScene");
            Debug.Log("Game over :)");
        }
    }
    public void PressSilent()
    {
        if (questionIndex < 29)
        {
            susspicionBar.value += 2;
            questionIndex++;
            question.text = allQuestions[questionIndex];
        }
        else
        {
            SceneManager.LoadScene("WinEndScene");
            //ending.text = endForThisGame;
            //question.text = PickAndDisplayEnding();
            Debug.Log("Game over :)");
        }
    }

    
}