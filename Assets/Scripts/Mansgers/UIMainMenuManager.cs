using UnityEngine;
using UnityEngine.UI;
using Model;
using System;

public class UIMainMenuManager : MonoBehaviour
{

    [SerializeField] private InputField _count;
    [SerializeField] private Text _countError;


    private Data _data;

	void Start ()
    {

        _count.contentType = InputField.ContentType.IntegerNumber;
        _data = Game.SceneController.GetData();
        _count.text = _data.Count.ToString();

    }

    public void OnCatsGameStart()
    {
        if (!string.IsNullOrEmpty(_count.text) && Convert.ToInt32(_count.text) != 0)
        {
            Game.SceneController.LoadLevel(ToData(DataType.Rabbit));
            _countError.gameObject.SetActive(false);
        }

        else
        {
            _countError.gameObject.SetActive(true);
        }
    }

    public void OnDogsGameStart()
    {
        if (!string.IsNullOrEmpty(_count.text) && Convert.ToInt32(_count.text) != 0)
        {
            Game.SceneController.LoadLevel(ToData(DataType.Dog));
            _countError.gameObject.SetActive(false);
        }

        else
        {
            _countError.gameObject.SetActive(true);
        }
    }

    private Data ToData(DataType type)
    {
        _data.Count = Convert.ToInt32(_count.text);
        _data.Type = type;
        return _data;
    }
	
	
}
