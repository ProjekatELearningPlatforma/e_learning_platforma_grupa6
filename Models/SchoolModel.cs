using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Models
{
  public class SchoolModel
  {    
     [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string SchoolId { get; set; }

    [BsonElement("SchoolName")]
    [Required]
    public string SchoolName { get; set; }

    [BsonElement("SchoolDescription")]
    [Required]
    public string SchoolDescription { get; set; }

    [BsonElement("SchoolCourseLinkOne")]
    [Required]
    public string SchoolCourseLinkOne { get; set; }

    [BsonElement("SchoolCourseLinkTwo")]
    [Required]
    public string SchoolCourseLinkTwo { get; set; }

    [BsonElement("SchoolCourseLinkThree")]
    [Required]
    public string SchoolCourseLinkThree { get; set; }
  }
}
