using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Ranks
{
    SpecialGrade = 0,
    Grade1,
    Grade2,
    Grade3,
    Grade4,
}

public enum State
{
    Staying,
    Working,
}
 
[CreateAssetMenu(fileName ="SorcererData", menuName ="SO/SorcererData")]
public class SorcererDataSO : ScriptableObject
{
    public Sprite Image;
    public string Name;
    [Header("SorceryData")]
    public string SorceryName;
    public string SorceryDescription;
    [Header("Stats")]
    public Ranks Grade;
    public int Power;
    public int Mood;
}
