using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SwapiAPIExample.Models
{
    public class StarWarsDAL
    {
        
        public Person GetPerson(int id)
        {
            // First step: put in your Endpoint (URL)
            string url = $"https://swapi.dev/api/people/{id}";

            // Next: Create our request
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // Next: If your API needs any kind of login or key,
            // that may go here.
            // SWAPI doesn't need anything special

            // Now we are ready to send off our request and grab the servers
            // response. Inside out response, the resulting data lives.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Pull result into a stream reader which will then give us a string.
            StreamReader rd = new StreamReader(response.GetResponseStream());

            // Grab out response string
            // ReadToEnd starts at the top of our file and returns each line
            // until it hits the end.
            string result = rd.ReadToEnd();

            // This line converts out Json string
            // into a person object automatically
            Person p = JsonConvert.DeserializeObject<Person>(result);

            // Later we'll convert our string into a model which makes it much easier to 
            // use for .net
            return p;
        }

        public Planet GetPlanet(int id)
        {
            // First step: put in your Endpoint (URL)
            string url = $"http://swapi.dev/api/planets/{id}";

            // Next: Create our request
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // Next: If your API needs any kind of login or key,
            // that may go here.
            // SWAPI doesn't need anything special

            // Now we are ready to send off our request and grab the servers
            // response. Inside out response, the resulting data lives.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Pull result into a stream reader which will then give us a string.
            StreamReader rd = new StreamReader(response.GetResponseStream());

            // Grab out response string
            // ReadToEnd starts at the top of our file and returns each line
            // until it hits the end.
            string result = rd.ReadToEnd();

            // This line converts out Json string
            // into a person object automatically
            Planet p = JsonConvert.DeserializeObject<Planet>(result);

            // Later we'll convert our string into a model which makes it much easier to 
            // use for .net
            return p;
        }

        public PeopleSearchResults GetPeople(int page)
        {
            // First step: put in your Endpoint (URL)
            string url = $"http://swapi.dev/api/people/?{page}";

            // Next: Create our request
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // Next: If your API needs any kind of login or key,
            // that may go here.
            // SWAPI doesn't need anything special

            // Now we are ready to send off our request and grab the servers
            // response. Inside out response, the resulting data lives.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Pull result into a stream reader which will then give us a string.
            StreamReader rd = new StreamReader(response.GetResponseStream());

            // Grab out response string
            // ReadToEnd starts at the top of our file and returns each line
            // until it hits the end.
            string result = rd.ReadToEnd();

            // This line converts out Json string
            // into a person object automatically
            PeopleSearchResults p = JsonConvert.DeserializeObject<PeopleSearchResults>(result);

            // Later we'll convert our string into a model which makes it much easier to 
            // use for .net
            return p;
        }
    }
}
