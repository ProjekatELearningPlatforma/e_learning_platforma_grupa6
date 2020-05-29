using E_Learning_Platforma.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Services
{
  public class SchoolServices
  {
    private IMongoCollection<SchoolModel> SchoolData;
    public SchoolServices(IConfiguration config)
    {
      MongoClient client = new MongoClient(config.GetSection("MongoDbSettings")["ConnectionString"]);
      //automatically create database
      IMongoDatabase database = client.GetDatabase("ELearningPlatforma");//db name
      //automatically create collection
      SchoolData = database.GetCollection<SchoolModel>("SchoolCollection");//collection name

    }    
     //Get all school data in mongodb
    public IEnumerable<SchoolModel> AllSchools()
    {
      return SchoolData.Find(x => true).ToList();
    }
     //create school in mongodb
    public void CreateSchool(SchoolModel model)
    {
      SchoolData.InsertOne(model);
    }
    //single data get in mongodb
    public SchoolModel GetOneSchool(string id)
    {
      return SchoolData.Find(x => x.SchoolId == id).FirstOrDefault();
    }
    //edit school data in mongodb
    public void EditSchool(string id, SchoolModel model)
    {
      SchoolData.ReplaceOne(x => x.SchoolId == id, model);
    }
    //delete course in mongodb
    public void DeleteSchool(SchoolModel model)
    {
      SchoolData.DeleteOne(x => x.SchoolId == model.SchoolId);
    }    
  }
}
