using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using NetCoreJWTAuthentication.Models;

namespace NetCoreJWTAuthentication.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> users;
        public UserService(IConfiguration configuration){
            var client = new MongoClient(configuration.GetConnectionString("HyphenDb"));
            var database = client.GetDatabase("HyphenDB");
            users = database.GetCollection<User>("Users");
        }
        public List<User> GetUsers ()=> users.Find(user=>true).ToList();

        public User GetUser(string id) =>users.Find<User>(user=>user.Id == id).FirstOrDefault();

        public User Create(User user){
            users.InsertOne(user);
            return user;
        }
    }
}