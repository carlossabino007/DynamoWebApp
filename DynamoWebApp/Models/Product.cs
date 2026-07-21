using Amazon.DynamoDBv2.DataModel;

namespace DynamoWebApp.Models;

[DynamoDBTable("products")]
public class Product
{
    [DynamoDBHashKey("rank")]
    public int Rank { get; set; }

    [DynamoDBProperty("youtuber")]
    public string? Youtuber { get; set; }

    [DynamoDBProperty("subscribers")]
    public string? Subscribers { get; set; }

    [DynamoDBProperty("video_views")]
    public string? Video_views { get; set; }

    [DynamoDBProperty("video_count")]
    public string? Video_count { get; set; }

    [DynamoDBProperty("category")]
    public string? Category { get; set; }

    [DynamoDBProperty("started")]
    public int Started { get; set; }
}

//using Amazon.DynamoDBv2.DataModel;

//namespace DynamoWebApp.Models;

//[DynamoDBTable("products")]
//public class Product
//{
//    [DynamoDBHashKey("rank")]
//    public int Rank { get; set; }

//    [DynamoDBProperty("youtuber")]
//    public string? Youtuber { get; set; }

//    [DynamoDBProperty("subscribers")]
//    public string? Subscribers { get; set; }

//    [DynamoDBProperty("video_views")]
//    public string? Video_views { get; set; }

//    [DynamoDBProperty("video_count")]
//    public string? Video_count { get; set; }

//    [DynamoDBProperty("category")]
//    public string? Category { get; set; }

//    [DynamoDBProperty("started")]
//    public int Started { get; set; }
//}