using UnityEngine;
using UnityEngine.Events;

public class DistanceCounter : MonoBehaviour
{
    [SerializeField] private Transform _firstTarget;
    [SerializeField] private Transform _secondTarget;

    [SerializeField] private float _minDistance;
    [SerializeField] private float _maxDistance;

    public UnityEvent OnMinDistance;

    public UnityEvent OnLessMaxDistance;
    public UnityEvent OnHighMaxDistance;

    private float _distance;

    private void Update()
    {
        _distance = Vector3.Distance(_firstTarget.position, _secondTarget.position);   
        
        if (_distance < _maxDistance)
        {
            OnLessMaxDistance?.Invoke();
        }
        else
        {
            OnHighMaxDistance?.Invoke();
        }

        if (_distance <= _minDistance)
        {
            OnMinDistance?.Invoke();
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 40), $"Расстояние между кубами: {_distance}");
    }
}
