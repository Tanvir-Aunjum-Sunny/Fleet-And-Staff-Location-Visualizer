﻿namespace Assets.Scripts.Data.Model.Objects
{
    public sealed class Building : BaseObject
    {
        public string Address;
        public string Name;

        public override string ToString()
        {
            return string.Format("Building: {0} at {1}\r\n" +
                                 "LatLng: {2:0.######}; {3:0.######}",
                Name, Address, Latitude, Longitude);
        }
    }
}