using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class NYUTisch : NYUStudent
{
    public int age = 0;

    public NYUTisch(
        string name, string netId,
        float gpa, int credits, int age) :
        base (name, netId, gpa, credits)
    {
        this.gpa = gpa;
        this.credits = credits;
        this.gpa = gpa;
        this.credits = credits;
        this.age = age;
        
        type = "NYU Tisch Student";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "age: " + age + "\n";
    }
}
