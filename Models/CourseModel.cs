using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Models
{
  public class CourseModel
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string CourseId { get; set; }

    [BsonElement("CourseName")]
    [Required]
    public string CourseName { get; set; }

    [BsonElement("CourseLink")]
    [Required]
    public string CourseLink { get; set; }

    [BsonElement("CourseDescription")]
    [Required]
    public string CourseDescription { get; set; }    

    [BsonElement("CourseCategory")]
    [Required]
    public string CourseCategory { get; set; }
  }
}
