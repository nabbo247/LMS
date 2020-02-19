using System;

namespace HRS.CoursePlayer
{
    [Serializable]
    public class AiccTime
    {
        private TimeSpan _time;
        public AiccTime()
        {
            _time = new TimeSpan(0);
        }
        public AiccTime(int seconds)
        {
            _time = new TimeSpan(0, 0, seconds);
        }
        public AiccTime(TimeSpan timeSpan)
        {
            _time = timeSpan;
        }

        public AiccTime(string aiccFormatTime)
        {
            string[] timeParts = aiccFormatTime.Split(":".ToCharArray());
            try
            {
                if (timeParts[0].Contains("."))
                {
                    int intDays = 0;
                    int intHrs = 0;
                    if (Int32.TryParse(timeParts[0].Split(new char[] { '.' })[0], out intDays) &&
                        Int32.TryParse(timeParts[0].Split(new char[] { '.' })[1], out intHrs))
                        timeParts[0] = (intHrs + intDays).ToString();
                }
                _time = new TimeSpan(Int32.Parse(timeParts[0]),
                    Int32.Parse(timeParts[1]),
                    Int32.Parse(timeParts[2].Substring(0, 2))
                    );
            }
            catch
            {
                throw new ArgumentException("Time not in AICC Format.");
            }
        }

        public int Seconds
        {
            get { return (int)Math.Floor(_time.TotalSeconds); }
        }

        public TimeSpan Time
        {
            get { return _time; }
        }

        public override string ToString()
        {
            return String.Format("{0:0000}:{1:00}:{2:00}", (int)Math.Floor(_time.TotalHours), _time.Minutes,
                                 _time.Seconds);
        }
    }
}