using Model;

public static class Game
{

    private static SceneController _sceneController;
    public static SceneController SceneController { get { return _sceneController; } }

    private static DataLayer _dataLayer;

    public static void Init()
    {
        _sceneController = new SceneController();
        _dataLayer = new DataLayer();
        _sceneController.Init(_dataLayer);
    }
}
