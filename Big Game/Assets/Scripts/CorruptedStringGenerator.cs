using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorruptedStringGenerator : Generator
{
    [SerializeField]
    private GameObject[] specialCharacters = null;

    [SerializeField]
    private Vector2[] spawnPosition = null;

    [SerializeField]
    private GameObject StringWormParent = null;

    public override void Start()
    {
        base.Start();
    }

    public override IEnumerator GenerateString()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, MaxDelay + 1));
            if (BinaryCharacters.Length == 0 || specialCharacters.Length == 0)
                yield return null;
            int randomSpawnPosition = Random.Range(0,spawnPosition.Length);

            Vector2 headPos = spawnPosition[randomSpawnPosition];
            GameObject _go = Instantiate<GameObject>(StringWormParent, spawnPosition[randomSpawnPosition], Quaternion.identity);
            int randomNum = Random.Range(MinNumberOfCharacterInString, MaxNumberOfCharacterInString + 1);

            GameObject head = Instantiate<GameObject>(BinaryCharacters[Random.Range(0, BinaryCharacters.Length)], spawnPosition[randomSpawnPosition], Quaternion.identity, _go.transform);
            HeadMovement headMovement = head.AddComponent<HeadMovement>();
            Vector2 lastPosition = spawnPosition[randomSpawnPosition];

            // Generate special characters
            for (int _indx = 1; _indx < randomNum -1; _indx++)
            {

                int randomChar = Random.Range(0, specialCharacters.Length);
                lastPosition = SpawnPosition(lastPosition);
                GameObject go = Instantiate<GameObject>(specialCharacters[randomChar], lastPosition, Quaternion.identity, _go.transform);
                headMovement.TailTransforms.Add(go.transform);
            }

            GameObject end = Instantiate<GameObject>(BinaryCharacters[Random.Range(0, BinaryCharacters.Length)], SpawnPosition(lastPosition), Quaternion.identity, _go.transform);
            headMovement.TailTransforms.Add(end.transform);
        }
    }

    public override Vector3 SpawnPosition(Vector2 lastPos)
    {
        return base.SpawnPosition(lastPos);
    }
}
