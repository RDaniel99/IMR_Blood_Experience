namespace VRTK.Examples
{
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    using UnityEngine;
    using UnityEngine;

    public class VRTKExample_BezierPointerCustomStyles : VRTKExample_BezierPointerChanger
    {
        public Color validLocationColor = new Color(0.431f, 0.682f, 0.788f);
        public Color invalidLocationColor = new Color(0.545f, 0.149f, 0.208f);
        public GameObject tracerPrefab;
        public GameObject cursorPrefab;
        public GameObject validLocationPrefab;
        public GameObject invalidLocationPrefab;
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