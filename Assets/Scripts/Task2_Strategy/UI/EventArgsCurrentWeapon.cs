using System;

namespace Task2.Strategy
{
    public class EventArgsCurrentWeapon : EventArgs
    {
        public string CurrentWeapon { get; private set; }
        public EventArgsCurrentWeapon(string currentWeapon) => CurrentWeapon = currentWeapon;
    }
}
