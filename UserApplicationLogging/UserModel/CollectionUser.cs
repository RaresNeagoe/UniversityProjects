using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using AppLogging;

namespace UserModel
{
    public class CollectionUser
    {

        private ILog _logger = LogFactory.Instance;

        public List<User> Users { get; private set; }

        public CollectionUser()
        {
            Users = new List<User>();
        }

        public void Add(User User)
        {
            if (Users.Any(u => u.Username == User.Username))
            {
                var errorMessage = $"User with username {User.Username} already exists in the collection.";
                _logger.Log(new LogModel { Message = errorMessage, Level = (int)LogLevel.Error });
                throw new Exception(errorMessage);
            }

            else
            {
                Users.Add(User);
                var infoMessage = $"User with username {User.Username} was added to the collection.";
                _logger.Log(new LogModel { Message = infoMessage, Level = (int)LogLevel.Info });
            }
        }

        public bool Remove(User User)
        {
            if (Users.Contains(User))
            {
                Users.Remove(User);
                return true;
            }

            return false;
        }

        public void SaveOnDisk()
        {
            string filePath = ConfigurationManager.AppSettings["UserFolder"];


            string jsonFormat = JsonConvert.SerializeObject(Users, Formatting.Indented);


            System.IO.File.WriteAllText(filePath, jsonFormat);
        }

        public void LoadFromDisk()
        {
            string filePath = ConfigurationManager.AppSettings["UserFolder"];

            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                Users.Clear();

                Users = JsonConvert.DeserializeObject<List<User>>(json);

                var infoMessage = $"Collection of users was saved on disk.";
                _logger.Log(new LogModel { Message = infoMessage, Level = (int)LogLevel.Info });
            }
        }
    }
}
