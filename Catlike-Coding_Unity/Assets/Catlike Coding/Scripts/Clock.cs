using System;
using UnityEngine;
public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    bool m_analogClock;

    [SerializeField]
    Transform m_hoursPivot, m_minutesPivot, m_secondsPivot;

    private void Update()
    {
        if (m_analogClock)
            AnalogClock();
        else
            DigitalClock();
    }

    private void AnalogClock()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        m_hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        m_minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        m_secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

    private void DigitalClock()
    {
        var time = DateTime.Now;
        m_hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        m_minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        m_secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
}