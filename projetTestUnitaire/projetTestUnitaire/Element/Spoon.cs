using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using projetTestUnitaire;

namespace projetTestUnitaire
{
    public class Spoon 
    {   int pv;

        RecupPv<Spoon> rlp = new RecupPv<Spoon>();
        
        public void RecupLifePoint()
        {
            
        }
        public bool verifVivant()
        {
            RecupLifePoint();

            if (pv > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadTheRock()
        {
            Rock r = new Rock();
            r.poids = 100;
            r.taille = 100;
            string message = "loaded";
            Console.WriteLine(message);
        }

       /*static async Task<string> DownloadLibraryAsync()
        {
            // notre cible
            

            using (HttpClient client = new HttpClient())
            {
                // autre possibilité
                //client.BaseAddress = new Uri(page);

                // on peut compléter le header
                //client.DefaultRequestHeaders.Add("X-TEST", "123");

                // la requête
                using (HttpResponseMessage response = await client.GetAsync(page))
                {

                    using (HttpContent content = response.Content)
                    {
                        // récupère la réponse, il ne resterai plus qu'à désérialiser
                        string result = await content.ReadAsStringAsync();
                        return result;
                    }
                }
            }
        }
        */
    }
}
