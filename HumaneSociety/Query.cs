﻿using System;
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

        public static void GetAnimalByID(int iD)
        {

        }

        public static void Adopt()
        {

        }

        public static void RetrieveClients()
        {

        }

        public static void GetStates()
        {

        }

        public static Client AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            Client client = new Client();
            client.firstName = firstName;
            client.lastName = lastName;
            client.userName = username;
            client.pass = password;
            client.email = email;
            client.UserAddress1.addessLine1 = streetAddress;
            client.UserAddress1.zipcode = zipCode;
            client.UserAddress1.USStates = state;
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

        public static void GetShots(Animal animal)
        {

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

        public static void GetBreed()
        {

        }

        public static void GetDiet()
        {

        }

        public static IQueryable<int?> GetLocation()
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animals name?");
            string userInput = Console.ReadLine();
            var location = context.Animals.Where(c => c.name == userInput).Select(c => c.location);
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
