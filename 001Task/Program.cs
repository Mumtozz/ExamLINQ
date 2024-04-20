using _001Task.Data;

await using var dataContext = new DataContext();

Console.WriteLine(" Good look 😊😊😊 ");

//1
//Напишите запрос LINQ, чтобы получить всех людей, живущих в городе с населением более 3 милион человек.
//Write a LINQ query to retrieve all the people who live in a city with a population greater than 3 

// var res = (from p in dataContext.Peoples
//           join c in dataContext.Cities on p.CityId equals c.Id
//           where c.Population > 3000000 
//           select new {
//             people = p,
//             city  = c
//           });
//           foreach (var item in res)
//           {
//             System.Console.WriteLine($"{item.people.FirstName} {item.people.LastName} {item.city.Name}");
//           }


//2
//Получите все города со средней численностью населения в соответствующей стране
//Retrieve all cities with their respective country's average population


var res2 = (from c in dataContext.Cities
           join cnt in dataContext.Countries on c.CountryId equals cnt.Id
           let avg = dataContext.Cities.Average(e => e.Population)
           select new {
                country = cnt,
                city = c,
                Average = avg
           });
           foreach (var item in res2)
           {
                System.Console.WriteLine($"{item.city.Name}");
           }


//3
//Получите города с самым высоким населением в каждой стране
//Retrieve the cities with the highest population in each country


// var res3 = from c in dataContext.Cities
//            join cnt in dataContext.Countries on c.CountryId equals cnt.Id
//            let MaxPopulation = dataContext.Cities.Max(e => e.Population)
//            select new {
//                 country = cnt,
//                 city = c,
//            };
//            foreach (var item in res3)
//            {
//                 System.Console.WriteLine($"{item.city.Name} {item.country.Name} {item.city.Population}");
//            }


//4
//Получите среднее население городов в каждой стране
//Retrieve the average population of cities in each country


// var res4 = (from c in dataContext.Cities
//            join cnt in dataContext.Countries on c.CountryId equals cnt.Id
//            select new {
//                 country = cnt,
//                 city = c,
//                 population = cnt.Cities!.Average(e => e.Population)
//            });
//            foreach (var item in res4)
//            {
//                 System.Console.WriteLine($"City:{item.city.Name} Population =  {item.population}");
//            }





//5
//Получить все города, в которых есть человек по имени "Марк".
//Retrieve all cities that have a person with by name "Mark"

// var res5 = (from c in dataContext.Cities
//            join p in dataContext.Peoples on c.Id equals p.CityId
//            where p.FirstName == "Mark"
//            select new {
//                 city = c
//            });

//            foreach (var item in res5)
//            {
//                 System.Console.WriteLine($"{item.city.Name}");
//            }


//6
//Получить всех людей вместе с соответствующими названиями городов и стран
//Retrieve all people along with their associated city and country names




// var res6 = (from p in dataContext.Peoples
//              join c in dataContext.Cities on p.CityId equals c.Id
//              join cnt in dataContext.Countries on c.CountryId equals cnt.Id
//              where p.CityId == c.Id && c.CountryId == cnt.Id
//              select new {
//                 people = p,
//                 city = c,
//                 country = cnt
//              });
//              foreach (var item in res6)
//              {
//                 System.Console.WriteLine($"PeopleName: {item.people.FirstName} CityName: {item.city.Name} CountryName: {item.country.Name}");
//              }



// var res6 = (from p in dataContext.Peoples
//              join c in dataContext.Cities on p.CityId equals c.Id
//              join cnt in dataContext.Countries on c.CountryId equals cnt.Id
             
//              select new {
//                 people = p,
//                 city = c,
//                 country = cnt
//              });
//              foreach (var item in res6)
//              {
//                 System.Console.WriteLine($"PeopleName: {item.people.FirstName} CityName: {item.city.Name} CountryName: {item.country.Name}");
//              }





//7
//Получите все города вместе с соответствующими названиями стран, используя свойство навигации
//Retrieve all cities along with their associated country names using a navigation property

// var res7 = (from c in dataContext.Cities
//            join cnt in dataContext.Countries on c.CountryId equals cnt.Id
//            select new {
//                 city = c,
//                 country = c
//            });
//            foreach (var item in res7)
//            {
//                 System.Console.WriteLine($"{item.city.Name} {item.country.Name}");
//            }


//8
//Получить всех людей вместе с связанными с ними городом и страной.
//Retrieve all people along with their associated city and country 


// var res8 = (from p in dataContext.Peoples
//              join c in dataContext.Cities on p.CityId equals c.Id
//              join cnt in dataContext.Countries on c.CountryId equals cnt.Id
//              select new {
//                 people = p,
//                 city = c,
//                 country = cnt
//              });
//              foreach (var item in res8)
//              {
//                 System.Console.WriteLine($"PeopleName:{item.people.FirstName} CityName:{item.city.Name} CountryName:{item.country.Name}");
//              }





//9
//Получить всех людей, живущих в "USA".
//Retrieve all people living in  "USA".

// var res9 = (from p in dataContext.Peoples
//            join c in dataContext.Cities on p.CityId equals c.Id
//            where c.Name == "USA"
//            select new {
//                 people = p
//            });

//            foreach (var item in res9)
//            {
//                 System.Console.WriteLine($"{item.people.FirstName} {item.people.LastName}");
//            }


//10
//Получить всех людей вместе с соответствующим населением города и страны
//Retrieve all people along with their associated city and country populations 


// var res10 = (from p in dataContext.Peoples
//              join c in dataContext.Cities on p.CityId equals c.Id
//              join cnt in dataContext.Countries on c.CountryId equals cnt.Id
//              let CityPopulation = dataContext.Cities.Sum(e => e.Population)
//              select new {
//                 people = p,
//                 citypop = CityPopulation,
//                 city = c,
//                 country = cnt,
//                 CountryPopulation = cnt.Cities!.Sum(e => e.Population)

//              });
//              foreach (var item in res10)
//              {
//                 System.Console.WriteLine(@$"PeopleName: {item.people.FirstName} - CityName: {item.city.Name} -- CountryName:  {item.country.Name}  -- CityPopulation = {item.CountryPopulation}");
//              }





