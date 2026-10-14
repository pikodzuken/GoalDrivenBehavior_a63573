using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;
    private static readonly Queue<GameObject> patients = new Queue<GameObject>();

    static GWorld()
    {
        world = new WorldStates();
    }

    private GWorld()
    {

    }

    public void AddPatient(GameObject p)
    {
        patients.Enqueue(p);
    }

    public bool HasPatients
    {
        get { return patients.Count > 0; }
    }

    public GameObject RemovePatient()
    {
        if (patients.Count == 0) return null;
        return patients.Dequeue();
    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}