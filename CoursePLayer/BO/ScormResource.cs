 
using System;
namespace HRS.CoursePlayer
{
   [Serializable] public class ScormResource
    {
        public string Identifier { get; set; }

        public string ScormType { get; set; }

        public string Type { get; set; }

        public string Base { get; set; }

        public string Href { get; set; }
    }
}
