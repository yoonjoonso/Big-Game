using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Generator : MonoBehaviour
{
    [Tooltip("Character game object to use to generate strings")]
    [SerializeField]
    private GameObject[] binaryCharacters = null;

    [SerializeField]
    private int minNumberOfCharacterInString = 3;

    [SerializeField]
    private int maxNumberOfCharacterInString = 7;

    [SerializeField]
    private float minDelay = 1f;

    [SerializeField]
    private float maxDelay = 5f;

    [SerializeField]
    private float xOffSet = .2f;

    [SerializeField]
    private float yOffSet = .3f;


    #region Properties
    public GameObject[] BinaryCharacters
    {
        get
        {
            return binaryCharacters;
        }

        set
        {
            binaryCharacters = value;
        }
    }

    public int MinNumberOfCharacterInString
    {
        get
        {
            return minNumberOfCharacterInString;
        }

        set
        {
            minNumberOfCharacterInString = value;
        }
    }

    public int MaxNumberOfCharacterInString
    {
        get
        {
            return maxNumberOfCharacterInString;
        }

        set
        {
            maxNumberOfCharacterInString = value;
        }
    }

    public float MaxDelay
    {
        get
        {
            return maxDelay;
        }

        set
        {
            maxDelay = value;
        }
    }

    public float XOffSet
    {
        get
        {
            return xOffSet;
        }

        set
        {
            xOffSet = value;
        }
    }

    public float YOffSet
    {
        get
        {
            return yOffSet;
        }

        set
        {
            yOffSet = value;
        }
    }
    #endregion

    public virtual void Start()
    {
        StartCoroutine(GenerateString());
    }

    public virtual IEnumerator GenerateString()
    {
        yield return new WaitForEndOfFrame();
    }

    public virtual Vector3 SpawnPosition(Vector2 lastPos)
    {
        Vector2 pos = Vector2.zero;

        int random = Random.Range(0, 2);
        if (random == 0)
        {
            pos.x = lastPos.x + XOffSet;
            pos.y = lastPos.y;
        }
        else if (random == 1)
        {
            pos.y = lastPos.y + YOffSet;
            pos.x = lastPos.x;
        }
        return pos;
    }
}
