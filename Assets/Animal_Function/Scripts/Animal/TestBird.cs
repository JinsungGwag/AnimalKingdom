using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBird : Bird
{
    public override void Initiate()
    {
        walkSpeed = 15f;
        rotXSpeed = 100f;
        rotYSpeed = 50f;

        flySpeed = 50f;

        base.Initiate();
    }
}
