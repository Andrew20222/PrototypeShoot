using UnityEngine;

public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _prefab;
    [SerializeField] Transform _pointToSpawn;

    public T GetNewInstance()
    {
        Vector3 pos = new Vector3(_pointToSpawn.position.x, _prefab.transform.position.y, _pointToSpawn.position.z);
        return Instantiate(_prefab, pos, Quaternion.identity);
    }
}
