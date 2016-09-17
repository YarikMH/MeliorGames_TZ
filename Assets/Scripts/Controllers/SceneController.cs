using UnityEngine;
using Model;
using UnityEngine.SceneManagement;

public class SceneController
{

    private IDataLayer _dataLayer;

	public void Init(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }

    public void LoadLevel(Data data, int lvl = 2)
    {
        _dataLayer.SaveData(data);
        SceneManager.LoadScene(lvl);
    }

    public Data GetData()
    {
        return _dataLayer.LoadData();
    }

    public void ToMainMenuScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ToGameScene()
    {
        SceneManager.LoadScene(1);
    }

}
