using UnityEngine;
using UnityEngine.Audio;

public class Toggler : MonoBehaviour
{
    private const string MasterControllerName = "Master";

    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private bool _isPlaying = true;
    private float _minToggleMusicVolumeValue = -80;
    private float _maxToggleMusicVolumeValue = 0;

    public void ToggleAudio()
    {
        if (_isPlaying == false)
            _audioMixerGroup.audioMixer.SetFloat(MasterControllerName, _maxToggleMusicVolumeValue);
        else
            _audioMixerGroup.audioMixer.SetFloat(MasterControllerName, _minToggleMusicVolumeValue);

        _isPlaying = !_isPlaying;
    }
}
