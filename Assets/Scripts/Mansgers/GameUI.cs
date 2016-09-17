using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    [SerializeField] private Text _sorryText;

    void Awake()
    {
        EventsManager.OnOutOfRange += OnOutOfRange;
    }

	public void OnBackToMenu()
    {
        Game.SceneController.ToMainMenuScene();
    }

    public void OnOutOfRange()
    {
        if (_sorryText != null)
        {
            _sorryText.text = "Sorry, we don`t have more animals... But just give them some time";
        }
    }
}
