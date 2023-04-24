using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUITP : NYUTisch
{
    public int year;
    
    public NYUITP(
        string name, string netId,
        float gpa, int credits, int age) :
        base (name, netId, gpa, credits, age)
    {
        this.gpa = gpa;
        this.credits = credits;
        this.gpa = gpa;
        this.credits = credits;
        this.age = age;
        type = "NYU ITP Student";
        year = 2024;
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "Year: " + year + "\n";
    }
}
