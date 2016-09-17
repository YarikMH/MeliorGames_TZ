using UnityEngine;

public class GameManager : MonoBehaviour
{
	void Start ()
    {
        Game.Init();
        DontDestroyOnLoad(this);
        Game.SceneController.ToMainMenuScene();
    }
}
