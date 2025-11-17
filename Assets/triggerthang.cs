using UnityEngine;
using UnityEngine.Playables;

public class triggerthang : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }
}