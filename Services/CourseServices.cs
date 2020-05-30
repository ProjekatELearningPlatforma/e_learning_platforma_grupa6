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
    //Get all courses by category 
    public IEnumerable<CourseModel> AllCoursesByCategory(string category)
    {
      return CourseData.Find(x => x.CourseCategory == category).ToList();
    }
    //create coursedata in mongodb
    public void CreateCourse(CourseModel model)
    {
      CourseData.InsertOne(model);
    }
    //get one course from mongodb 
    public CourseModel GetOneCourse(string id)
    {
      return CourseData.Find(x => x.CourseId == id).FirstOrDefault();
    }
    //edit course data in mongodb
    public void EditCourse(string id, CourseModel model)
    {
      CourseData.ReplaceOne(x => x.CourseId == id, model);
    }
    //delete course in mongodb
    public void DeleteCourse(CourseModel model)
    {
      CourseData.DeleteOne(x => x.CourseId == model.CourseId);
    }   
  }
}
