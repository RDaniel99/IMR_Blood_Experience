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
        protected override void StyleRenderer(VRTK_BezierPointerRenderer renderer)
        {
            score=int.Parse(scoreUI.text);
            score=score+correct;
            scoreUI.text=score.ToString();
        }
    }
}