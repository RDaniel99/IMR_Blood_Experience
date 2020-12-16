using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    using UnityEngine;

public class QuizController : MonoBehaviour
{
    public Text question;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public Text scoreUI;
    public int score;
    public int no=0;
    void nextQuestion(int no){
        if(no==2)
        {question.text="What kind of cell is an eusinophil?";
        answer1.text="Blue cell";
        answer2.text="White cell";
        answer3.text="Red cell";}
        else if(no==4){
question.text="What does a virus do?";
        answer1.text="Nothing";
        answer2.text="It kills red cells";
        answer3.text="Microchips you";
        }
        else if(no==6){
question.text="What is blood made of?";
        answer1.text="Veins";
        answer2.text="Cells";
        answer3.text="Viruses";
        }
        else if(no==8){
            question.text="Quiz done! Good job!";
            answer1.text="";
            answer2.text="Score:"+scoreUI.text;
            answer3.text="";
        }
    }

    public void changeScore(int correct)
    {
            score=int.Parse(scoreUI.text);
            score=score+correct;
            scoreUI.text=score.ToString();
            no=no+1;
            nextQuestion(no);
    }
}
