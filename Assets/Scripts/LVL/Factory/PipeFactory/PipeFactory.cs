using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeFactory : BaseFactory<PipePrefab>
{


    void Start()
    {
        PrefabSpawned.Add(_firstPrefab[0]);



    }

    private void Update()
    {
        Spawned();
    }
    public override PipePrefab Spawned()
    {
        PipePrefab newPipe = Instantiate(BasePrefabs[Random.Range(0, BasePrefabs.Length)]);
        var previousEndPos = new Vector3(0, 0, PrefabSpawned[PrefabSpawned.Count - 1]._end.position.z);
        var endPos = newPipe._end.position;

        newPipe.transform.position = previousEndPos + endPos;
        PrefabSpawned.Add(newPipe);
        return null;
    }
}
