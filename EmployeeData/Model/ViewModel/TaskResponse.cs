using Newtonsoft.Json;
using System.Collections.Generic;

namespace EmployeeData.Model.ViewModel
{
    public class TaskResponse  // Make this class public
    {
        [JsonProperty("list")]
        public List<ListData> List { get; set; }

        public class ListData  // Make this class public
        {
            [JsonProperty("idTask")]
            public int IdTask { get; set; }

            [JsonProperty("idTaskType")]
            public int IdTaskType { get; set; }

            [JsonProperty("idTaskSubtype")]
            public object IdTaskSubtype { get; set; }

            [JsonProperty("idTaskStatus")]
            public int IdTaskStatus { get; set; }

            [JsonProperty("idTaskResult")]
            public object IdTaskResult { get; set; }

            [JsonProperty("idTaskPriority")]
            public int IdTaskPriority { get; set; }

            [JsonProperty("location")]
            public Location Locationn { get; set; }

            public class Location  // Make this class public
            {
                [JsonProperty("idLocation")]
                public int IdLocation { get; set; }

                [JsonProperty("idLocationStatus")]
                public int IdLocationStatus { get; set; }

                [JsonProperty("idLocationType")]
                public int IdLocationType { get; set; }

                [JsonProperty("idProject")]
                public int IdProject { get; set; }

                [JsonProperty("accountNumber")]
                public string AccountNumber { get; set; }

                [JsonProperty("customerName")]
                public string CustomerName { get; set; }

                [JsonProperty("phoneNumber")]
                public string PhoneNumber { get; set; }

                [JsonProperty("address")]
                public object Address { get; set; }

                [JsonProperty("priority")]
                public object Priority { get; set; }

                [JsonProperty("latitude")]
                public float? Latitude { get; set; }

                [JsonProperty("longitude")]
                public float? Longitude { get; set; }

                [JsonProperty("region")]
                public object Region { get; set; }

                [JsonProperty("area")]
                public object Area { get; set; }

                [JsonProperty("geoCode")]
                public object GeoCode { get; set; }
            }
        }
    }
}
