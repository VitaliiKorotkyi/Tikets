using VKTiketsPG.Models;

namespace VKTiketsPG.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (context != null)
                {
                    context.Database.EnsureCreated();
                    //Cinema
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            Logo="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            Name="Cinema 2",
                            Logo="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            Name="Cinema 3",
                            Logo="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            Name="Cinema 4",
                            Logo="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="This is the description of the first cinema"

                        },new Cinema()
                        {
                            Name="Cinema 5",
                            Logo="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description="This is the description of the first cinema"

                        },
                    });
                        context.SaveChanges();

                    }
                    //Actors
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Actor 1",
                            Bio="Thi is the bio of the first actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-1.jpeg"

                        },new Actor()
                        {
                            FullName="Actor 2",
                            Bio="Thi is the bio of the second actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-2.jpeg"

                        },new Actor()
                        {
                            FullName="Actor 3",
                            Bio="Thi is the bio of the three actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-3.jpeg"

                        },new Actor()
                        {
                            FullName="Actor 4",
                            Bio="Thi is the bio of the four actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-4.jpeg"

                        },new Actor()
                        {
                            FullName="Actor 5",
                            Bio="Thi is the bio of the fifth actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-5.jpeg"

                        },

                    });
                        context.SaveChanges();
                    }
                    //Producers
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Producer 1",
                            Bio="Thi is the bio of the first Producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/roducer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName="Producer 2",
                            Bio="Thi is the bio of the second Producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/roducer-2.jpeg"

                        },
                        new Producer()
                        {
                            FullName="Producer 3",
                            Bio="Thi is the bio of the thre Producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/roducer-3.jpeg"

                        },
                        new Producer()
                        {
                            FullName="Producer 4",
                            Bio="Thi is the bio of the four Producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/roducer-4.jpeg"

                        },
                        new Producer()
                        {
                            FullName="Producer 5",
                            Bio="Thi is the bio of the fifth Producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/roducer-5.jpeg"

                        }
                    });
                        context.SaveChanges();
                    }
                    //Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name="The Shawsank Redemption",
                            Description="Thi is the description of the The Shawsank Redemption movie",
                            Price=29.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(3),
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory=MovieCategory.Action

                        },
                        new Movie()
                        {
                            Name="Ghost",
                            Description="Thi is the description of the Ghost movie",
                            Price=19.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=1,
                            ProducerId=2,
                            MovieCategory=MovieCategory.Horror

                        },
                        new Movie()
                        {
                            Name="Scoob",
                            Description="Thi is the description of the Scoob movie",
                            Price=19.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-2),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Cartoon

                        },
                        new Movie()
                        {
                            Name="Cold Soles",
                            Description="Thi is the description of the Cold Soles movie",
                            Price=39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-1),
                            CinemaId=1,
                            ProducerId=2    ,
                            MovieCategory=MovieCategory.Drama

                        },
                        new Movie()
                        {
                            Name="Race",
                            Description="Thi is the description of the Race movie",
                            Price=39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-7),
                            CinemaId=1,
                            ProducerId=5,
                            MovieCategory=MovieCategory.Drama

                        },
                         new Movie()
                        {
                            Name="Life",
                            Description="Thi is the description of the Life movie",
                            Price=39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate=DateTime.Now.AddDays(-4),
                            EndDate=DateTime.Now.AddDays(6),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Comedy

                        }
                    });
                        context.SaveChanges();
                    }
                    //Actors_Movies
                    if (!context.Actors_Movies.Any())
                    {
                        var actorMoviesToAdd = new List<Actor_Movie>()
    {
        new Actor_Movie() { ActorId = 1, MovieId = 3 },
        new Actor_Movie() { ActorId = 2, MovieId = 3 },
        new Actor_Movie() { ActorId = 5, MovieId = 3 },
        new Actor_Movie() { ActorId = 2, MovieId = 4 },
        new Actor_Movie() { ActorId = 3, MovieId = 5 },



    };

                        foreach (var actorMovie in actorMoviesToAdd)
                        {
                            if (!context.Actors_Movies.Any(am => am.ActorId == actorMovie.ActorId && am.MovieId == actorMovie.MovieId))
                            {
                                context.Actors_Movies.Add(actorMovie);
                            }
                        }

                        context.SaveChanges();
                    }

                }
            }
        }
    }
}


