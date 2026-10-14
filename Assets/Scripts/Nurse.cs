using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : GAgent
{
    SubGoal treatPatientGoal;

    void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("treatPatient", 1, false);
        goals.Add(s1, 3);
    }

    void Update()
    {
        if (GWorld.Instance.HasPatients && !goals.ContainsKey(treatPatientGoal))
        {
            goals.Add(treatPatientGoal, 3);
        }
    }

}