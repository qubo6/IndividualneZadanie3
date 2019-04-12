using Controls;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GeneratorClient
    {
        public ModelClient GenerateClient()
        {
            string generatedClient = new Generator().GetRandomPeople(1).ToList()[0];          
            string[] parsedPerson = generatedClient.Split(';');            

            ModelClient modelClient = new ModelClient()
            {
                LastName = parsedPerson[0],
                FirstName = parsedPerson[1],
                IdentityCard = parsedPerson[3].Replace(" ", String.Empty),
                PhoneNumber = parsedPerson[4].Replace(" ", String.Empty),
                Email = parsedPerson[5],                
            };
            return modelClient;
        }

        public ModelAddress GenerateAddress()
        {
            string generatedAddress = new Generator().GetRandomAddresses(1).ToList()[0];
            string[] parsedAddress = generatedAddress.Split(';');
            ModelAddress modelAddress = new ModelAddress()
            {
                Street = parsedAddress[0],
                PostalCode = parsedAddress[1].Replace(" ", String.Empty),
                City = parsedAddress[2]
            };
            return modelAddress;
        }
    }
}
