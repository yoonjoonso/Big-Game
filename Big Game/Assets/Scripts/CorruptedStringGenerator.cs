using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorruptedStringGenerator : Generator
{
    [SerializeField]
    private GameObject[] specialCharacters = null;

    [SerializeField]
    private Vector2 spawnPosition = Vector2.zero;

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

            Vector2 headPos = spawnPosition;
            int randomNum = Random.Range(MinNumberOfCharacterInString, MaxNumberOfCharacterInString + 1);

            GameObject head = Instantiate<GameObject>(BinaryCharacters[Random.Range(0, BinaryCharacters.Length)], spawnPosition, Quaternion.identity);
            Vector2 lastPosition = spawnPosition;

            // Generate special characters
            for (int _indx = 1; _indx < randomNum -1; _indx++)
            {

                int randomChar = Random.Range(0, specialCharacters.Length);
                lastPosition = SpawnPosition(lastPosition);
                Instantiate<GameObject>(specialCharacters[randomChar], lastPosition, Quaternion.identity, head.transform);
            }

            GameObject end = Instantiate<GameObject>(BinaryCharacters[Random.Range(0, BinaryCharacters.Length)], SpawnPosition(lastPosition), Quaternion.identity, head.transform);
        }
    }

    public override Vector3 SpawnPosition(Vector2 lastPos)
    {
        return base.SpawnPosition(lastPos);
    }
}
