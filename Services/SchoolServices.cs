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
  }
}
