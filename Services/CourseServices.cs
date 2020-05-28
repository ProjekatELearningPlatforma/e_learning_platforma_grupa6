using E_Learning_Platforma.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Services
{
  public class CourseServices
  {
    private IMongoCollection<CourseModel> CourseData;
    public CourseServices(IConfiguration config)
    {
      MongoClient client = new MongoClient(config.GetSection("MongoDbSettings")["ConnectionString"]);
      //automatically create database
      IMongoDatabase database = client.GetDatabase("ELearningPlatforma");//db name
      //automatically create collection
      CourseData = database.GetCollection<CourseModel>("CourseCollection");//collection name

    }    
    //Get all courses data from mongodb
    public IEnumerable<CourseModel> AllCourses()
    {
      return CourseData.Find(x => true).ToList();
    }   
  }
}
