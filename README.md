# Tech.CityBike
Sample .NET CRUD Project

## Note for me

In the **Application** project add a folder per feature (slice) and in that folder add a folder named interface. In this latest folder there will be the customization of the repository interface of the entity.

In the **Infrastructure** project the same folder structure will be implemented 

## sample_training.trips

[sample_training.trips](https://www.mongodb.com/docs/atlas/sample-data/sample-training/#std-label-training-trips)

```json
{
    "_id": {
      "$oid": "572bb8222b288919b68abf82"
    },
    "bikeid": 14785,
    "birth year": 1977,
    "end station id": 433,
    "end station location": {
        "coordinates": [
            -73.98057249,
            40.72955361
        ],
        "type": "Point"
    },
    "end station name": "E 13 St & Avenue A",
    "gender": 1,
    "start station id": 518,
    "start station location": {
        "coordinates": [
            -73.9734419,
            40.74780373
        ],
        "type": "Point"
    },
    "start station name": "E 39 St & 2 Ave",
    "start time": {
      "$date": {
        "$numberLong": "1332804016000"
      }
    },
    "stop time": {
      "$date": {
        "$numberLong": "1352114016000"
      }
    },
    "tripduration": 812,
    "usertype": "Subscriber"
}
```

```csharp
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Date
    {
        [JsonProperty("$numberLong")]
        public string NumberLong;
    }

    public class EndStationLocation
    {
        [JsonProperty("coordinates")]
        public List<double?> Coordinates;

        [JsonProperty("type")]
        public string Type;
    }

    public class Id
    {
        [JsonProperty("$oid")]
        public string Oid;
    }

    public class Root
    {
        [JsonProperty("_id")]
        public Id Id;

        [JsonProperty("bikeid")]
        public int? Bikeid;

        [JsonProperty("birth year")]
        public int? BirthYear;

        [JsonProperty("end station id")]
        public int? EndStationId;

        [JsonProperty("end station location")]
        public EndStationLocation EndStationLocation;

        [JsonProperty("end station name")]
        public string EndStationName;

        [JsonProperty("gender")]
        public int? Gender;

        [JsonProperty("start station id")]
        public int? StartStationId;

        [JsonProperty("start station location")]
        public StartStationLocation StartStationLocation;

        [JsonProperty("start station name")]
        public string StartStationName;

        [JsonProperty("start time")]
        public StartTime StartTime;

        [JsonProperty("stop time")]
        public StopTime StopTime;

        [JsonProperty("tripduration")]
        public int? Tripduration;

        [JsonProperty("usertype")]
        public string Usertype;
    }

    public class StartStationLocation
    {
        [JsonProperty("coordinates")]
        public List<double?> Coordinates;

        [JsonProperty("type")]
        public string Type;
    }

    public class StartTime
    {
        [JsonProperty("$date")]
        public Date Date;
    }

    public class StopTime
    {
        [JsonProperty("$date")]
        public Date Date;
    }


```