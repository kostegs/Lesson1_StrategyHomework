using System;

namespace Task2.Strategy
{
    public class EventArgsAmmoCount : EventArgs
    {
        public int AmmoCount {  get; private set; }
        public EventArgsAmmoCount(int ammoCount) => AmmoCount = ammoCount;        
    }
}
