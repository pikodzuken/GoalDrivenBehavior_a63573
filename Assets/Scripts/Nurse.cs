using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : GAgent
{
    SubGoal treatPatientGoal;

    void Start()
    {
        base.Start();
        treatPatientGoal = new SubGoal("treatPatient", 1, true);
    }

    void Update()
    {
        if (GWorld.Instance.HasPatients && !goals.ContainsKey(treatPatientGoal))
        {
            goals.Add(treatPatientGoal, 3);
        }
    }

}