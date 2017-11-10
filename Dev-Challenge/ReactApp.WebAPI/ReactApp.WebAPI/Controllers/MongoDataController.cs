using MongoDB.Driver;
using ReactApp.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ReactApp.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MongoDataController : ApiController
    {
            
       
            [Route("api/search/{query?}")]
            public List<Title> GetSearch(string query = null)
            {
                var test = query;

                //connecting and getting data from mongodb

                var connectionString = "mongodb://readonly:turner@ds043348.mongolab.com:43348/dev-challenge";
                var client = new MongoClient(connectionString);
                var _databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var database = client.GetDatabase(_databaseName);
                var titles = database.GetCollection<Title>("Titles");
                List<Title> alltitles = new List<Title>();

                if (test != null)
                {
                    alltitles = titles.AsQueryable().Where(c => c.TitleName.ToLower().Contains(test.ToLower())).ToList();
                }

                return alltitles;
            }
        }
    }

