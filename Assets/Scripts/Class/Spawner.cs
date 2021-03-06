﻿using System;
using System.Collections.Generic;

[Serializable]
public class Spawner {
    public string id;
    public int type;
    public float[] position;
    public float[] rotation;
    public float[] args;
    public float[] time;
    public List<Command> commands;
}