using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    private static TestGameManager _instance;
    public static TestGameManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance) Destroy(this);
        else _instance = this;
        DontDestroyOnLoad(this);
    }
}
