using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //10ft tall

        //TODO Make the property, "Tuesday", enum

        public enum Day { Monday,Tuesday,Wednesday,Thursday,Friday };

    }
}
