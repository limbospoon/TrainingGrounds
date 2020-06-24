using System;
using UnityEngine;
using UnityEngine.Playables;
using Cinemachine;

public class TimelineManager : MonoBehaviour
{
    public PlayableDirector timeLine;
    public Playables[] playableAsset;
    public bool useCinemachine;

    public static TimelineManager instance;

    private CinemachineBrain cinemachineBrain;

    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        timeLine.stopped += OnPlaybackEnded;
    }

    private void OnDisable()
    {
        timeLine.stopped -= OnPlaybackEnded;
    }

    private void Start()
    {
        if(useCinemachine)
        {
            cinemachineBrain = Camera.main.GetComponent<CinemachineBrain>();
            cinemachineBrain.enabled = false;
        }
    }

    public void PlayTimeline(string name, bool useCinemachine)
    {
        if(useCinemachine)
        {
            cinemachineBrain.enabled = true;
        }

        Playables p = Array.Find(playableAsset, playable => playable.name == name);
        if(p != null && timeLine.time <= 0)
        {
            timeLine.Play(p.playableAsset);
        }
    }

    public void StopTimeline()
    {
        timeLine.Stop();        
    }

    void OnPlaybackEnded(PlayableDirector playableDirector)
    {
        if (useCinemachine)
        {
            cinemachineBrain.enabled = false;
        }
    }
}
