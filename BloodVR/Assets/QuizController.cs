using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    using UnityEngine;
    using VRTK.Examples;

public class QuizController : MonoBehaviour
{
    public Text question;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public Text scoreUI;
    VRTKExample_BezierPointerLineRenderer panel1=null;
    VRTKExample_BezierPointerDefaults panel2=null;
    VRTKExample_BezierPointerCustomStyles panel3=null;
    public int score;
    public int no=0;
    void Start(){
        panel1=GameObject.Find("LineRendererOption").GetComponent<VRTKExample_BezierPointerLineRenderer>();
        panel2=GameObject.Find("ResetDefaultOption").GetComponent<VRTKExample_BezierPointerDefaults>();
        panel3=GameObject.Find("CustomStyleOption").GetComponent<VRTKExample_BezierPointerCustomStyles>();
    }
    void nextQuestion(int no){
        if(no==2)
        {question.text="What does blood flow through?";
        answer1.text="Bones";
        answer2.text="Veins";
        answer3.text="Air";
        panel1.correct=-1;
        panel2.correct=1;
        panel3.correct=-1;
        }
        else if(no==4){
        question.text="What does a virus do?";
        answer1.text="It kills red cells";
        answer2.text="Microchips you";
        answer3.text="Nothing";
        panel1.correct=1;
        panel2.correct=-1;
        panel3.correct=-1;
        }
        else if(no==6){
        question.text="What is blood made of?";
        answer1.text="Veins";
        answer2.text="Viruses";
        answer3.text="Cells";
        panel1.correct=-1;
        panel2.correct=-1;
        panel3.correct=1;
        }
        else if(no==8){
            question.text="What organ pumps blood continuously?";
        answer1.text="Heart";
        answer2.text="Pancreas";
        answer3.text="Lungs";
        panel1.correct=1;
        panel2.correct=-1;
        panel3.correct=-1;
        }
        else if(no==10){
            question.text="Which one is NOT a blood type?";
        answer1.text="A";
        answer2.text="D";
        answer3.text="O";
        panel1.correct=-1;
        panel2.correct=1;
        panel3.correct=-1;
        }
        else if(no==12){
            question.text="How many chambers does the heart have?";
        answer1.text="Six";
        answer2.text="Five";
        answer3.text="Four";
        panel1.correct=-1;
        panel2.correct=-1;
        panel3.correct=1;
        }
        else if(no==14){
            question.text="Which important gas does blood carry?";
        answer1.text="Helium";
        answer2.text="Neon";
        answer3.text="Oxygen";
        panel1.correct=-1;
        panel2.correct=-1;
        panel3.correct=1;
        }
        else if(no==16){
            question.text="Which metal in blood helps make red blood cells?";
        answer1.text="Calcium";
        answer2.text="Iron";
        answer3.text="Zinc";
        panel1.correct=-1;
        panel2.correct=1;
        panel3.correct=-1;
        }
        else if(no==18){
            question.text="Where are blood cells made?";
        answer1.text="Heart";
        answer2.text="Kidney";
        answer3.text="Bone Marrow";
        panel1.correct=-1;
        panel2.correct=-1;
        panel3.correct=1;
        }
        else if(no==20){
            question.text="What is the liquid in blood called?";
        answer1.text="Plasma";
        answer2.text="Water";
        answer3.text="Milk";
        panel1.correct=1;
        panel2.correct=-1;
        panel3.correct=-1;
        }
        else if(no==22){
            question.text="Quiz done! Good job!";
            answer1.text="";
            answer2.text="Score:"+scoreUI.text;
            answer3.text="";
            panel1.correct=0;
            panel2.correct=0;
            panel3.correct=0;
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
