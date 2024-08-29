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
