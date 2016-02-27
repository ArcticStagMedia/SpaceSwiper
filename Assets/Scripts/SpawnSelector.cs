//using UnityEngine;
//using System.Collections;

//public class SpawnSelector : MonoBehaviour
//{
//    public GameObject[] _Spawners;
//    int _SelectedSpawner;
//    int _PreviousSpawner = -1;
//    int SpawnerLength;
//    // Use this for initialization
//    void Start()
//    {
//        SpawnerLength = _Spawners.Length;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        while (true)
//        {

//            _SelectedSpawner = Random.Range(0, SpawnerLength);
//            if (_SelectedSpawner != _PreviousSpawner)
//            {
//                if (_Spawners[_SelectedSpawner].GetComponent<SpawnScriptLeft>())
//                {
//                    SpawnScriptLeft tempSpawnScript = _Spawners[_SelectedSpawner].GetComponent<SpawnScriptLeft>();
//                    tempSpawnScript.SetSpawn = true;
//                    _PreviousSpawner = _SelectedSpawner;
//                }
//                else if (_Spawners[_SelectedSpawner].GetComponent<SpawnScriptRight>())
//                {
//                    SpawnScriptRight tempSpawnScript = _Spawners[_SelectedSpawner].GetComponent<SpawnScriptRight>();
//                    tempSpawnScript.SetSpawn = true;
//                    _PreviousSpawner = _SelectedSpawner;
//                }
//            }
//        }
//    }

//}
