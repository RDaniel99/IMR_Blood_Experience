namespace VRTK.Examples
{using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    using UnityEngine;

    public class VRTKExample_BezierPointerDefaults : VRTKExample_BezierPointerChanger
    {
        public Text scoreUI;
        public int score;
        public int correct;
        public QuizController cont;
        public GameObject txt;
        protected override void StyleRenderer(VRTK_BezierPointerRenderer renderer)
        {
            cont=txt.GetComponent<QuizController>();
            cont.changeScore(correct);
        }
    }
}