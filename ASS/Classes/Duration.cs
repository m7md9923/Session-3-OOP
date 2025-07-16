namespace ASS.Classes
{
    internal class Duration
    {
        #region Attributes
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }
        #endregion
        #region Methods 
        public override string ToString()
        {
            return $"Hours: {Hours} ,Minutes: {Minutes} , Seconds: {Seconds} ";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration d)
            {
                return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;
            Minutes = seconds / 60;
            Seconds = seconds % 60;
        }
        public Duration()
        {
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hours = (d1?.Hours ?? 0) + (d2?.Hours ?? 0),
                Minutes = (d1?.Minutes ?? 0) + (d2?.Minutes ?? 0),
                Seconds = (d1?.Seconds ?? 0) + (d2?.Seconds ?? 0)
            };
        }

        public static Duration operator +(Duration d1, int S)
        {
            Duration d2 = new Duration(S);
            return new Duration()
            {
                Hours = (d1?.Hours ?? 0) + (d2?.Hours ?? 0),
                Minutes = (d1?.Minutes ?? 0) + (d2?.Minutes ?? 0),
                Seconds = (d1?.Seconds ?? 0) + (d2?.Seconds ?? 0)
            };
        }
        public static Duration operator +(int S, Duration d1)
        {
            Duration d2 = new Duration(S);
            return new Duration()
            {
                Hours = (d1?.Hours ?? 0) + (d2?.Hours ?? 0),
                Minutes = (d1?.Minutes ?? 0) + (d2?.Minutes ?? 0),
                Seconds = (d1?.Seconds ?? 0) + (d2?.Seconds ?? 0)
            };
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hours = (d1?.Hours ?? 0) - (d2?.Hours ?? 0),
                Minutes = (d1?.Minutes ?? 0) - (d2?.Minutes ?? 0),
                Seconds = (d1?.Seconds ?? 0) - (d2?.Seconds ?? 0)
            };
        }

        public static Duration operator ++(Duration d1)
        {
            return new Duration()
            {
                Hours = (d1?.Hours ?? 0),
                Minutes = (d1?.Minutes ?? 0) + 1,
                Seconds = (d1?.Seconds ?? 0)
            };
        }
        public static Duration operator --(Duration d1)
        {
            return new Duration()
            {
                Hours = (d1?.Hours ?? 0),
                Minutes = (d1?.Minutes ?? 0) - 1,
                Seconds = (d1?.Seconds ?? 0)
            };
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1 == null || d2 == null) 
                return false;
            if (d1.Hours > d2.Hours) 
                return true;
            else if (d1.Hours == d2.Hours)
            {
                if (d1.Minutes > d2.Minutes)
                    return true;
                else if (d1.Minutes == d2.Minutes)
                    return d1.Seconds > d2.Seconds;
            }
            return false;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1 == null || d2 == null)
                return false;

            if (d1.Hours < d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours)
            {
                if (d1.Minutes < d2.Minutes)
                    return true;
                else if (d1.Minutes == d2.Minutes)
                    return d1.Seconds < d2.Seconds;
            }
            return false;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return !(d1 < d2);
        }
        public static implicit operator bool(Duration d1)
        {
            return d1 != null && (d1.Hours >= 0 || d1.Minutes >= 0 || d1.Seconds >= 0);
        }

        public static explicit operator DateTime(Duration d1)
        {
            return new DateTime(1, 1, 1, d1.Hours, d1.Minutes, d1.Seconds);
        }
        #endregion

    }
}