using UnityEngine;
using Model;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;

    private List<GameObject> _pool;
    private Data _data;

    void Start()
    {

        _data = Game.SceneController.GetData();
        _pool = new List<GameObject>();
        

        switch (_data.Type)
        {
            case DataType.Dog:

                var dogPrefab = Resources.Load("dog");

                for (int i = 0; i < _data.Count; i++)
                {

                   if (i >= _spawnPoints.Length)
                   {
                       EventsManager.RaiseOnOutOfRange();
                       return;
                   }

                   var dog = (GameObject)Instantiate(dogPrefab, _spawnPoints[i].position, Quaternion.identity);
                   dog.transform.parent = _spawnPoints[i];
                   dog.SetActive(true);
                    _pool.Add(dog);
                   
                }

                return;

            case DataType.Rabbit:

                var rabbitPrefab = Resources.Load("Rabbit");

                for (int i = 0; i < _data.Count; i++)
                {
                  if (i >= _spawnPoints.Length)
                  {
                      EventsManager.RaiseOnOutOfRange();
                      return;
                  }

                  var rabbit = (GameObject)Instantiate(rabbitPrefab, _spawnPoints[i].position, Quaternion.identity);
                  rabbit.transform.parent = _spawnPoints[i];
                  rabbit.SetActive(true);
                  _pool.Add(rabbit);

                }

                return;
        }

    }

}