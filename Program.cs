using LinqTraining01;
using static LinqTraining01.Data;

// IEnumerables /////////////////////////////////////////////////////////
// IEnumerables /////////////////////////////////////////////////////////
// IEnumerables /////////////////////////////////////////////////////////
// IEnumerables /////////////////////////////////////////////////////////

var data = new Data();
var intList = data.IntList;
var friends = data.Friends;
var objectList = data.ObjectList;
var personList = data.PersonList;
var employees = data.Employees;

// LINQ //////////////////////////////////////////////////////////////////
// LINQ //////////////////////////////////////////////////////////////////
// LINQ //////////////////////////////////////////////////////////////////
// LINQ //////////////////////////////////////////////////////////////////

// QuerySyntax ///////////////////////////////////////////////////////////
// Select all INTS with value greater than 2
var querySyntax = from obj in intList
                  where obj > 2
                  select obj;

// MethodSyntax //////////////////////////////////////////////////////////
var methodSyntax = intList
    .Where(obj => obj > 2);

// MixedSyntax ///////////////////////////////////////////////////////////
// Find Max value in list
var mixedSyntax = (from obj in intList
                   select obj).Max();

// List of Object ////////////////////////////////////////////////////////
// Find employees whose name contains 'Rich'
// (Both ways Return 'Richard' & 'Rich')

// QuerySyntax
var query1 = from emp in employees
             where emp.FirstName.Contains("Rich")
             select emp;

// MethodSyntax
var method1 = employees
    .Where(emp => emp.FirstName.Contains("Rich"));

// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - 
// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - 
// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - 
// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT -

// If we just want to select ALL items in the list....
// and not change anything ==>
var query2 = (from emp in employees
              select emp).ToList();

var method2List = employees.ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Now lets choose only the ids (Creates a List<int>)
var query3 = (from emp in employees
              select emp.Id).ToList();

var method3 = employees
    .Select(emp => emp.Id).ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Now lets choose only the ids and increase their values by 1 (Creates a List<int>)
var query4 = (from emp in employees
              select emp.Id + 1).ToList();

var method4 = employees
    .Select(emp => emp.Id + 1).ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Now I only want to select 2 properties (Id & email)
// And save to another class (with similar properties of course)

// Saving to a different class 'Student'
var query5 = (from emp in employees
              select new StudentClass()
              {
                  StudentId = emp.Id,
                  StudentEmail = emp.Email,
              })
    .ToList();

// Using ANONYMOUS class 
var method5 = employees
    .Select(emp => new
    {
        AnonymousClassId = emp.Id,
        AnonymousClassEmail = emp.Email
    })
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Select including Index!
var method6 = employees
    .Select((emp, index) => new
    {
        AnonymousClassIndex = index,
        AnonymousClassEmail = emp.Email
    })
    .ToList();

// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 
// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 
// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 
// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 

// Du använder SelectMany när du har 'samlingar av samlingar' och vill
// skapa en enkel, sammanhängande lista.

// people.SelectMany(p => p.Friends):
// Tar alla Friends från varje person och plattar ut dem till en lista.

// Distinct(): Tar bort dubbletter.

// ToList(): Konverterar resultatet till en lista.

// Resultat:
// ["Bill", "Cathy", "Anna", "David"]

var allFriends = personList
    .SelectMany(p => p.Friends)
    .Distinct()
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Contents of a LIST can also be flattened

// SelectMany will create 1 single list from all the programming skills in 
// the employees List
// There are 5 employees with 3 skills each...

// SELECTMANY - ONE list of FIFTEEN (3 skills * 5 employees)
// CREATES DOUBLES! (if C# exists 'twice' it will appear in the new list 'twice')
var query8a = (from emp in employees
               from skill in emp.ProgrammingStringList
               select skill)
               .ToList();

var method8a = employees.SelectMany(emp => emp.ProgrammingStringList).ToList();

// SELECT - Creates FIVE lists of THREE (5 employees * 3 skills)
var method8b = employees.Select(emp => emp.ProgrammingStringList).ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Contents of a LIST IN AN OBJECT ('Tech') can also be flattened
// SelectMany will create 1 single list from all the Tech skills 

// NOTE: Employee "Rich" has no Tech attributes (his Tech list is empty)!

var query9 = (from emp in employees
              from t in emp.TechsObjectList
              select t).ToList();

var method9 = employees.SelectMany(emp => emp.TechsObjectList).ToList();

// Again if we use SELECT instead the list WONT be flattened.
// We get 1 list containing 5 lists (1 list for each employee)

var method9b = employees.Select(emp => emp.TechsObjectList).ToList();

// ///////////////////////////////////////////////////////////////////////////////
// FILTERING - FILTERING - FILTERING - FILTERING - FILTERING - FILTERING -
// FILTERING - FILTERING - FILTERING - FILTERING - FILTERING - FILTERING -
// FILTERING - FILTERING - FILTERING - FILTERING - FILTERING - FILTERING -
// FILTERING - FILTERING - FILTERING - FILTERING - FILTERING - FILTERING -
// ///////////////////////////////////////////////////////////////////////////////

// ///////////////////////////////////////////////////////////////////////////////
// WHERE - WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE - 
// WHERE - WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE - 
// WHERE - WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE - 
// WHERE - WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE -  WHERE - 

// Find all ints greater than 5 OR greater than 9
var query10 = (from num in intList
               where num < 5 || num > 9
               select num)
              .ToList();

var method10 = intList
    .Where(num => num < 5 || num > 9)
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Select all friends with 4 letters in their name and name starts with L
var query11 = (from name in friends
               where name.Length == 4 && name.StartsWith("L")
               select name)
              .ToList();

var method11 = friends
    .Where(name => name.Length == 4 && name.StartsWith("A"))
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// Select employees who have no Techs in Tech list and name contains "Rich"
// Id 5 "Rich" will be chosen as his Tech list is empty
var query12 = (from emp in employees
               where emp.TechsObjectList.Count == 0 && emp.FirstName.Contains("Rich")
               select emp)
              .ToList();

var method12 = employees
    .Where(emp => emp.TechsObjectList.Count == 0 && emp.FirstName.Contains("Rich"))
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE

// Select only ints
var query13 = (from obj in objectList
               where obj is int
               select obj)
              .ToList();

// Select only strings with length greater than 5
var method13 = objectList
    .OfType<string>()
    .Where(name => name.Length > 5)
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - 
// SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - 
// SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - 
// SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - SORTING - 
// ///////////////////////////////////////////////////////////////////////////////

// ///////////////////////////////////////////////////////////////////////////////
// Order by - Order by - Order by - Order by - Order by - Order by - Order by - 
// ///////////////////////////////////////////////////////////////////////////////

// Select all ints greater than 10 and then sort ascending
var query14 = (from num in intList
               where num > 10
               orderby num
               select num)
              .ToList();

var method14 = intList
    .Where(num => num > 10)
    .OrderBy(num => num)
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////

// String list
// Select friend with name of 5 letters
var query15 = (from name in friends
               where name.Length == 5
               orderby name
               select name)
             .ToList();

var method15 = friends
    .Where(name => name.Length == 5)
    .OrderBy(name => name)
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////

// Object
// Sort employees by email where the Id is greater than 2
var query16 = (from emp in employees
               where emp.Id > 2
               orderby emp.Email
               select emp)
              .ToList();

var method16 = employees
    .OrderBy(emp => emp.Email)
    .Where(emp => emp.Id > 2)
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// OrderByDescending -  OrderByDescending - OrderByDescending - OrderByDescending -
// ///////////////////////////////////////////////////////////////////////////////

// Same as OrderBy...
var query17 = (from num in intList
               orderby num descending
               select num)
              .ToList();

var method17 = intList
    .OrderByDescending(num => num)
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// THENBY -  THENBY -  THENBY -  THENBY -  THENBY -  THENBY -  THENBY -  THENBY - 
// ///////////////////////////////////////////////////////////////////////////////

var query18 = (from emp in employees
               orderby emp.FirstName, emp.LastName
               select emp)
              .ToList();

var method18 = employees
    .OrderBy(emp => emp.FirstName)
    .ThenBy(emp => emp.LastName)
    .ToList();

// ///////////////////////////////////////////////////////////////////////////////
// REVERSE -  REVERSE - REVERSE - REVERSE - REVERSE - REVERSE - REVERSE - REVERSE -
// ///////////////////////////////////////////////////////////////////////////////

var query19 = (from num in intList
               select num)
               .Reverse()
               .ToList();

//You cannot store the data like below as this method belongs to
//System.Collections.Generic namespace whose return type is void
// var method19 = intList.Reverse();

var method19 = intList
    .AsEnumerable() // Must convert to IEnumerable first
    .Reverse()
    .ToList();

int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

var method20 = nums
    .Reverse();

// ///////////////////////////////////////////////////////////////////////////////
// QUANTIFIERS -  QUANTIFIERS - QUANTIFIERS - QUANTIFIERS - QUANTIFIERS - QUANTIFIERS -
// ///////////////////////////////////////////////////////////////////////////////

// ///////////////////////////////////////////////////////////////////////////////
// ANY -  ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY -
// ///////////////////////////////////////////////////////////////////////////////

// Returns a BOOL!
// If ANY of the items fullfill the specified condition

var query21 = (from num in nums
               select num)
    .Any(x => x > 5);

// This will return TRUE
var method211 = nums
    .Any(num => num > 0);

// This will return FALSE (NONE of the values are larger than 50)
var method212 = nums
    .Any(num => num > 50);

// ///////////////////////////////////////////////////////////////////////////////
// CONTAINS - CONTAINS - CONTAINS - CONTAINS - CONTAINS - CONTAINS - CONTAINS -
// ///////////////////////////////////////////////////////////////////////////////

// Does Danny exist in friends list? (returns True)
var query22 = (from friend in friends
               select friend)
                .Contains("Danny");

// Does Richard exist in friends list? (returns False)
var method22 = friends.Contains("Richard");

// ///////////////////////////////////////////////////////////////////////////////
// DISTINCT - DISTINCT - DISTINCT - DISTINCT - DISTINCT - DISTINCT - DISTINCT -
// ///////////////////////////////////////////////////////////////////////////////

var query23 = (from num in intList
               select num).Distinct().ToList();

// Without the ToList() method this will simply be a 'query'
// ... (and therefore nothing we can loop through)

// Return only distinct number from intList (Query only)
var method23 = intList.Distinct();

// Return only distinct number from intList (As a list)
var method23List = intList.Distinct().ToList();

// Lets have a look at the distinct names of our employees
var query24 = (from emp in employees
               select emp.FirstName)
               .Distinct()
               .ToList();

// Lets have a look at the distinct names of our employees
var method24 = employees
    .Select(emp => emp.FirstName)
    .Distinct();

// ///////////////////////////////////////////////////////////////////////////////
// TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE -
// ///////////////////////////////////////////////////////////////////////////////

// Takes only the first 5 from the list (irrespective of value)
var query25 = (from num in intList
               select num)
               .Take(5)
               .ToList();

var method25a = intList.Take(5);

// Takes only the max 5 from the list (incl doublettes)
var method25b = intList
    .OrderByDescending(num => num)
    .Take(5);

// Takes only the min 5 from the list (excl doublettes)
var method25c = intList
    .OrderBy(num => num)
    .Distinct()
    .Take(5);

// ///////////////////////////////////////////////////////////////////////////////
// SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP -
// ///////////////////////////////////////////////////////////////////////////////

// Skip the first 9 values in the list
var query26 = (from num in intList
               select num)
               .Skip(9)
               .ToList();

var method26a = intList.Take(9);

// Skip the first 9 values in the list
var method26b = intList
    .OrderByDescending(num => num)
    .Skip(9);

// ///////////////////////////////////////////////////////////////////////////////
// FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST -
// ///////////////////////////////////////////////////////////////////////////////

// Return the FIRST value greater that 6
// OBS: If no value matches criteria this will return an exception!!
// Lets try to change the syntax to look for number 16! What happens?
var query27 = (from num in intList
               select num)
               .First(num => num > 6);

var method27 = intList.First(num => num > 6);

// First is the same as WHERE... but it stops at the first hit and returns a single object
// Even if there is only one number greater than 6 in the list... "Where" will return a list with one item
var method27b = intList.Where(num => num > 6);

// ///////////////////////////////////////////////////////////////////////////////
// FIRSTORDEFAULT -  FIRSTORDEFAULT -  FIRSTORDEFAULT -  FIRSTORDEFAULT - 
// ///////////////////////////////////////////////////////////////////////////////

// Return the FIRST or DEFAULT value (if not found) greater that 6
// OBS: If no value matches criteria this will return an default value!!
// Lets try to change the syntax to look for number 16! What happens?
var query28 = (from num in intList
               select num)
               .FirstOrDefault(num => num > 6);

var method28 = intList.FirstOrDefault(num => num > 6);

// ///////////////////////////////////////////////////////////////////////////////
// LOOP IN A LOOP - LOOP IN A LOOP - LOOP IN A LOOP - LOOP IN A LOOP
// ///////////////////////////////////////////////////////////////////////////////

var query29 = (from emp in employees
               select emp);

foreach (var emp in query29)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName}");

    foreach (var tech in emp.TechsObjectList)
    {
        Console.WriteLine($"{tech.Technology}");

    }
    Console.WriteLine("================================");
}

// ///////////////////////////////////////////////////////////////////////////////
// INCLUDE - INCLUDE - INCLUDE - INCLUDE - INCLUDE - INCLUDE - INCLUDE - INCLUDE - 
// ///////////////////////////////////////////////////////////////////////////////

// Vi använder INCLUDE då vår entity har andra entiteter (klasser) inom sig.
// tex. En lista med Orders

// Motsvarar 
// (SQL) SELECT * FROM CUSTOMERS
// (LINQ) var customers = context.Customers.ToList();

// Motsvarar

// (SQL) SELECT * FROM Customers JOIN Orders ON Customers.Id = Orders.CustomerId;
// (LINQ) var customersWithOrderDetail = context.Customers.Include("Orders").ToList();

// ///////////////////////////////////////////////////////////////////////////////
Console.ReadKey();

