
namespace AzureSearch.SDKHowTo
{
    using System;
    using System.Linq;
    using System.Threading;
    using Microsoft.Azure.Search;
    using Microsoft.Azure.Search.Models;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Spatial;

    public class SearchIndexHelper
    {
        public SearchIndexHelper(IConfigurationRoot configuration,string indexName)
        {
        }

        // Upload documents in a single Upload request.
        // Upload documents as a batch.
        public static void UploadDocuments(ISearchIndexClient indexClient)
        {
            var actions = new IndexAction<Hotel>[]
            {
                IndexAction.Upload(
                    new Hotel()
                    {
                        HotelId = "1",
                        HotelName = "Secret Point Motel",
                        Description = "The hotel is ideally located on the main commercial artery of the city in the heart of New York. A few minutes away is Time's Square and the historic centre of the city, as well as other places of interest that make New York one of America's most attractive and cosmopolitan cities.",
                        DescriptionFr = "L'hôtel est idéalement situé sur la principale artère commerciale de la ville en plein cœur de New York. A quelques minutes se trouve la place du temps et le centre historique de la ville, ainsi que d'autres lieux d'intérêt qui font de New York l'une des villes les plus attractives et cosmopolites de l'Amérique.",
                        Category = "Boutique",
                        Tags = new[] { "pool", "air conditioning", "concierge" },
                        ParkingIncluded = false,
                        LastRenovationDate = new DateTimeOffset(1970, 1, 18, 0, 0, 0, TimeSpan.Zero),
                        Rating = 3.6,
                        Location = GeographyPoint.Create(40.760586, -73.975403),
                        Address = new Address()
                        {
                            StreetAddress = "677 5th Ave",
                            City = "New York",
                            StateProvince = "NY",
                            PostalCode = "10022",
                            Country = "USA"
                        },
                        Rooms = new Room[]
                        {
                            new Room()
                            {
                                Description = "Budget Room, 1 Queen Bed (Cityside)",
                                DescriptionFr = "Chambre Économique, 1 grand lit (côté ville)",
                                Type = "Budget Room",
                                BaseRate = 96.99,
                                BedOptions = "1 Queen Bed",
                                SleepsCount = 2,
                                SmokingAllowed = true,
                                Tags = new[] { "vcr/dvd" }
                            },
                            new Room()
                            {
                                Description = "Budget Room, 1 King Bed (Mountain View)",
                                DescriptionFr = "Chambre Économique, 1 très grand lit (Mountain View)",
                                Type = "Budget Room",
                                BaseRate = 80.99,
                                BedOptions = "1 King Bed",
                                SleepsCount = 2,
                                SmokingAllowed = true,
                                Tags = new[] { "vcr/dvd", "jacuzzi tub" }
                            },
                            new Room()
                            {
                                Description = "Deluxe Room, 2 Double Beds (City View)",
                                DescriptionFr = "Chambre Deluxe, 2 lits doubles (vue ville)",
                                Type = "Deluxe Room",
                                BaseRate = 150.99,
                                BedOptions = "2 Double Beds",
                                SleepsCount = 2,
                                SmokingAllowed = false,
                                Tags = new[] { "suite", "bathroom shower", "coffee maker" }
                            }
                        }
                    }
                ),
                IndexAction.Upload(
                    new Hotel()
                    {
                        HotelId = "2",
                        HotelName = "Twin Dome Motel",
                        Description = "The hotel is situated in a  nineteenth century plaza, which has been expanded and renovated to the highest architectural standards to create a modern, functional and first-class hotel in which art and unique historical elements coexist with the most modern comforts.",
                        DescriptionFr = "L'hôtel est situé dans une place du XIXe siècle, qui a été agrandie et rénovée aux plus hautes normes architecturales pour créer un hôtel moderne, fonctionnel et de première classe dans lequel l'art et les éléments historiques uniques coexistent avec le confort le plus moderne.",
                        Category = "Boutique",
                        Tags = new[] { "pool", "free wifi", "concierge" },
                        ParkingIncluded = false,
                        LastRenovationDate =  new DateTimeOffset(1979, 2, 18, 0, 0, 0, TimeSpan.Zero),
                        Rating = 3.60,
                        Location = GeographyPoint.Create(27.384417, -82.452843),
                        Address = new Address()
                        {
                            StreetAddress = "140 University Town Center Dr",
                            City = "Sarasota",
                            StateProvince = "FL",
                            PostalCode = "34243",
                            Country = "USA"
                        },
                        Rooms = new Room[]
                        {
                            new Room()
                            {
                                Description = "Suite, 2 Double Beds (Mountain View)",
                                DescriptionFr = "Suite, 2 lits doubles (vue sur la montagne)",
                                Type = "Suite",
                                BaseRate = 250.99,
                                BedOptions = "2 Double Beds",
                                SleepsCount = 2,
                                SmokingAllowed = false,
                                Tags = new[] { "Room Tags" }
                            },
                            new Room()
                            {
                                Description = "Standard Room, 1 Queen Bed (City View)",
                                DescriptionFr = "Chambre Standard, 1 grand lit (vue ville)",
                                Type = "Standard Room",
                                BaseRate = 121.99,
                                BedOptions = "1 Queen Bed",
                                SleepsCount = 2,
                                SmokingAllowed = false,
                                Tags = new[] { "jacuzzi tub" }
                            },
                            new Room()
                            {
                                Description = "Budget Room, 1 King Bed (Waterfront View)",
                                DescriptionFr = "Chambre Économique, 1 très grand lit (vue sur le front de mer)",
                                Type = "Budget Room",
                                BaseRate = 88.99,
                                BedOptions = "1 King Bed",
                                SleepsCount = 2,
                                SmokingAllowed = false,
                                Tags = new[] { "suite", "tv", "jacuzzi tub" }
                            }
                        }
                    }
                ),
                IndexAction.MergeOrUpload(
                    new Hotel()
                    {
                        HotelId = "3",
                        HotelName = "Triple Landscape Hotel",
                        Description = "The Hotel stands out for its gastronomic excellence under the management of William Dough, who advises on and oversees all of the Hotel’s restaurant services.",
                        DescriptionFr = "L'hôtel est situé dans une place du XIXe siècle, qui a été agrandie et rénovée aux plus hautes normes architecturales pour créer un hôtel moderne, fonctionnel et de première classe dans lequel l'art et les éléments historiques uniques coexistent avec le confort le plus moderne.",
                        Category = "Resort and Spa",
                        Tags = new[] { "air conditioning", "bar", "continental breakfast" },
                        ParkingIncluded = true,
                        LastRenovationDate = new DateTimeOffset(2015, 9, 20, 0, 0, 0, TimeSpan.Zero),
                        Rating = 4.80,
                        Location = GeographyPoint.Create(33.84643, -84.362465),
                        Address = new Address()
                        {
                            StreetAddress = "3393 Peachtree Rd",
                            City = "Atlanta",
                            StateProvince = "GA",
                            PostalCode = "30326",
                            Country = "USA"
                        },
                        Rooms = new Room[]
                        {
                            new Room()
                            {
                                Description = "Standard Room, 2 Queen Beds (Amenities)",
                                DescriptionFr = "Chambre Standard, 2 grands lits (Services)",
                                Type = "Standard Room",
                                BaseRate = 101.99,
                                BedOptions = "2 Queen Beds",
                                SleepsCount = 4,
                                SmokingAllowed = true,
                                Tags = new[] { "vcr/dvd", "vcr/dvd" }
                            },
                            new Room ()
                            {
                                Description = "Standard Room, 2 Double Beds (Waterfront View)",
                                DescriptionFr = "Chambre Standard, 2 lits doubles (vue sur le front de mer)",
                                Type = "Standard Room",
                                BaseRate = 106.99,
                                BedOptions = "2 Double Beds",
                                SleepsCount = 2,
                                SmokingAllowed = true,
                                Tags = new[] { "coffee maker" }
                            },
                            new Room()
                            {
                                Description = "Deluxe Room, 2 Double Beds (Cityside)",
                                DescriptionFr = "Chambre Deluxe, 2 lits doubles (Cityside)",
                                Type = "Budget Room",
                                BaseRate = 180.99,
                                BedOptions = "2 Double Beds",
                                SleepsCount = 2,
                                SmokingAllowed = true,
                                Tags = new[] { "suite" }
                            }
                        }
                    }
                ),
                    
                IndexAction.MergeOrUpload (
                    new Hotel()
                    {
                        HotelId = "4",
                        HotelName = "suryiaBudgetHotels economy Hotel",
                        Description = "The Hotel stands out for its gastronomic excellence under the management of William Dough, who advises on and oversees all of the Hotel’s restaurant services.",
                        DescriptionFr = "L'hôtel est situé dans une place du XIXe siècle, qui a été agrandie et rénovée aux plus hautes normes architecturales pour créer un hôtel moderne, fonctionnel et de première classe dans lequel l'art et les éléments historiques uniques coexistent avec le confort le plus moderne.",
                        Category = "Resort and Spa",
                        Tags = new[] { "air conditioning", "bar", "continental breakfast" },
                        ParkingIncluded = true,
                        LastRenovationDate = new DateTimeOffset(2015, 9, 20, 0, 0, 0, TimeSpan.Zero),
                        Rating = 4.80,
                        Location = GeographyPoint.Create(33.84643, -84.362465)
                    }
                ),
                IndexAction.MergeOrUpload (
                    new Hotel()
                    {
                        HotelId = "5",
                        HotelName = "suryiaBudgetHotels highend Hotel",
                        Description = "The Hotel stands out for its gastronomic excellence under the management of William Dough, who advises on and oversees all of the Hotel’s restaurant services.",
                        DescriptionFr = "L'hôtel est situé dans une place du XIXe siècle, qui a été agrandie et rénovée aux plus hautes normes architecturales pour créer un hôtel moderne, fonctionnel et de première classe dans lequel l'art et les éléments historiques uniques coexistent avec le confort le plus moderne.",
                        Category = "Resort and Spa",
                        Tags = new[] { "air conditioning", "bar", "continental breakfast" },
                        ParkingIncluded = true,
                        LastRenovationDate = new DateTimeOffset(2015, 9, 20, 0, 0, 0, TimeSpan.Zero),
                        Rating = 4.80,
                        Location = GeographyPoint.Create(33.84643, -84.362465)
                    }
                ),


                IndexAction.Delete(new Hotel() { HotelId = "6" })
            };

            var batch = IndexBatch.New(actions);

            try
            {
                indexClient.Documents.Index(batch);
            }
            catch (IndexBatchException e)
            {
                // Sometimes when your Search service is under load, indexing will fail for some of the documents in
                // the batch. Depending on your application, you can take compensating actions like delaying and
                // retrying. For this simple demo, we just log the failed document keys and continue.
                Console.WriteLine(
                    "Failed to index some of the documents: {0}",
                    String.Join(", ", e.IndexingResults.Where(r => !r.Succeeded).Select(r => r.Key)));
            }

            Console.WriteLine("Waiting for documents to be indexed...\n");
            Thread.Sleep(2000);
        }


    }
}