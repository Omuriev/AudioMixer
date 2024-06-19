using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSwitcher : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private string _controllerName = "Master";

    private float _minVolumeValue = 0.0001f;
    private float _maxVolumeValue = 1f;

    private void OnEnable()
    {
        _volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _volumeSlider.onValueChanged?.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        _audioMixer.SetFloat(_controllerName, Mathf.Log10(Mathf.Clamp(volume, _minVolumeValue, _maxVolumeValue)) * 20);
    }
}
