# Domain Models

## Menu


```csharp
class Menu
{
        Menu Create();
        void AddDinner(Dinner dinner);
        void RemoveDinner(Dinner dinner);
        void UpdateSection(MenuSection section);
}
```

```json
{
  "id" : "000",
  "name" : "Yummy Menu",
  "description" : "Menu with yummy food",
  "averageRating" : 4.5,
  "sections" : [
    {
      "id" : "000000-000000-0000-000",
      "name": "Appetizers",
      "description": "Starters",
      "items": [
        {
          "id" : "00000000-00000000",
          "name": "Fried Pickles",
          "description": "Deep fried pickles",
          "price": 5.99
        }
      ]
    }
  ],
  "createdDateTime": "2024-02-20T00:00:00:00.000000Z",
  "updatedDateTime": "2024-02-21T00:00:00:00.000000Z",
  "hostId": "000-000",
  "dinnerIds" : 
  [
    "0000", "0000", "0000"
  ],
  "menuReviewIds": [
    "000000", "00000"
  ]
}
```
