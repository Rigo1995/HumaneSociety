using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {



        public static void GetPendingAdoptions()
        {
            HumaneSocietyDataContext getpendingadoptions = new HumaneSocietyDataContext();
            var pending = getpendingadoptions.Animals.Where(c => c.name == userInput).Select(c => c.location);
            return pending;
        }
        
        public static void RunEmployeeQueries(Employee employee, string action)
        {

        }

        public static Client GetClient(string username, string password)
        {
            Client currentClient = new Client();
            currentClient.userName = username;
            currentClient.pass = password;
            return currentClient;
        }

        public static IQueryable<ClientAnimalJunction>GetUserAdoptionStatus(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Client myClient = db.Clients.Where(x => x.ID == client.ID).First();
            //client.id
            //clientAniimalJunctions data set
            //return all matching entries with client.id
            return;
        }

        public static IQueryable<int?> GetAnimalByID()
        {
            HumaneSocietyDataContext getId = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animals ID?");
            string userInput = Console.ReadLine();
            var id = getId.Animals.Where(c => c.ID == userInput).Select(c => c.ID);
            return id;
        }

        public static void Adopt()
        {

        }

        public static IQueryable<int?> RetrieveClients()
        {
            HumaneSocietyDataContext getId = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animals ID?");
            string userInput = Console.ReadLine();
            var id = getId.Animals.Where(c => c.name == userInput).Select(c => c.ID);
            return animalId;
        }

        public static void GetStates()
        {

        }

        public static Client AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();

            Client client = new Client();
            client.firstName = firstName;
            client.lastName = lastName;
            client.userName = username;
            client.pass = password;
            client.email = email;
            client.UserAddress1.addessLine1 = streetAddress;
            client.UserAddress1.zipcode = zipCode;
            client.UserAddress1.USStates = state;

            context.Clients.InsertOnSubmit(client);
            context.SubmitChanges();
            return client;
        }

        public static void updateClient(Client client)
        {

        }

        public static void UpdateUsername(Client client)
        {

        }

        public static void UpdateEmail(Client client)
        {

        }

        public static void UpdateAddress(Client client)
        {

        }

        public static void UpdateFirstName(Client client)
        {

        }

        public static void UpdateLastName(Client client)
        {

        }

        public static void UpdateAdoption(bool adopt //,jucntion table
            )
        {

        }

        public static IQueryable<int?> GetShots(Animal animal)
        {
            HumaneSocietyDataContext getshots = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animals name?");
            string userInput = Console.ReadLine();
            var shots = getshots.AnimalShotJunctions.Where(b => b.Shot_ID == userInput).Select(b => b.);
            return shots;
        }

        public static void UpdateShot(string update, Animal updateshot)
        {

        }

        public static void EnterUpdate(string animal, string updates)
        {

        }

        public static void RemoveAnimal(string animal)
        {

        }

        public static IQueryable<int?> GetBreed()
        {
            HumaneSocietyDataContext getbreed = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animals name?");
            string userInput = Console.ReadLine();
            var breed = getbreed.Animals.Where(b => b.name == userInput).Select(b => b.breed);
            return breed;
        }

        public static IQueryable<int?> GetDiet()
        {
            HumaneSocietyDataContext getdiet = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animals name?");
            string userInput = Console.ReadLine();
            var diet = getdiet.Animals.Where(d => d.name == userInput).Select(d => d.diet);
            return diet;
        }

        public static IQueryable<int?> GetLocation()
        {
            HumaneSocietyDataContext getlocation = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animals name?");
            string userInput = Console.ReadLine();
            var location = getlocation.Animals.Where(c => c.name == userInput).Select(c => c.location);
            return location;
        }

        public static void AddAnimal()
        {
            
        }

        public static void EmployeeLogin()
        {

        }

        public static void RetrieveEmployeeUser(string email)
        {

        }

        public static void AddUsernameAndPassword(Employee employee)
        {

        }

        public static bool CheckEmployeeUserNameExist(string username)
        {
            
        }

    }
}
