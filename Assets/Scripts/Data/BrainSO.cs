using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ManagerConig", menuName = "ManagerConfig/Brain", order = 1)]
public class BrainSO : ScriptableObject
{
    public List<float> memoryLast10Game = new List<float>();
    public float memoryAverage;
    [Header("----------------------------------------------")]
    public List<float> speedLast10Game = new List<float>();
    public float speedAverage;
    [Header("----------------------------------------------")]
    public List<float> decisionLast10Game = new List<float>();
    public float decisionAverage;
    [Header("----------------------------------------------")]
    public List<float> observatýonLast10Game = new List<float>();
    public float observationAverage;
    [Header("----------------------------------------------")]
    public List<float> calculationLast10Game = new List<float>();
    public float calculataionAverage;

    //public void SetSave()
    //{
    //    ES3.Save("myMemoryLast10Game", memoryLast10Game);
    //    ES3.Save("mySpeedLast10Game", speedLast10Game);
    //    ES3.Save("myDecisionLast10Game", decisionLast10Game);
    //    ES3.Save("myObservatýonLast10Game", observatýonLast10Game);
    //    ES3.Save("myCalculationLast10Game", calculationLast10Game);
    //}

}
