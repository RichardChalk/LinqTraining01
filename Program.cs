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
var employees = data.Employees;

// LINQ //////////////////////////////////////////////////////////////////
// LINQ //////////////////////////////////////////////////////////////////
// LINQ //////////////////////////////////////////////////////////////////
// LINQ //////////////////////////////////////////////////////////////////

// QuerySyntax ///////////////////////////////////////////////////////////
// Select all INTS with value greater than 2




// MethodSyntax //////////////////////////////////////////////////////////



// MixedSyntax ///////////////////////////////////////////////////////////
// Find Max value in list



// List of Object ////////////////////////////////////////////////////////
// Find employees whose name contains 'Rich'
// (Both ways Return 'Richard' & 'Rich')

// QuerySyntax




// MethodSyntax



// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - 
// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - 
// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - 
// SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT - SELECT -

// If we just want to select ALL items in the list....
// and not change anything ==>





// ///////////////////////////////////////////////////////////////////////////////
// Now lets choose only the ids (Creates a List<int>)






// ///////////////////////////////////////////////////////////////////////////////
// Now lets choose only the ids and increase their values by 1 (Creates a List<int>)






// ///////////////////////////////////////////////////////////////////////////////
// Now I only want to select 2 properties (Id & email)
// And save to another class (with similar properties of course)

// Saving to a different class 'Student'








// Using ANONYMOUS class 








// ///////////////////////////////////////////////////////////////////////////////
// Select including Index!








// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 
// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 
// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 
// SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - SELECTMANY - 

// This method will flatten the results of any sequence
// result: 1 array with 15 letters
// DannyThomasLeif







// ///////////////////////////////////////////////////////////////////////////////
// Contents of a LIST can also be flattened

// SelectMany will create 1 single list from all the programming skills in 
// the employees List
// There are 5 employees with 3 skills each...

// SELECTMANY - ONE list of FIFTEEN (3 skills * 5 employees)
// CREATES DOUBLES! (if C# exists 'twice' it will appear in the new list 'twice')







// SELECT - Creates FIVE lists of THREE (5 employees * 3 skills)


// ///////////////////////////////////////////////////////////////////////////////
// Contents of a LIST IN AN OBJECT ('Tech') can also be flattened
// SelectMany will create 1 single list from all the Tech skills 

// NOTE: Employee "Rich" has no Tech attributes (his Tech list is empty)!







// Again if we use SELECT instead the list WONT be flattened.
// We get 1 list containing 5 lists (1 list for each employee)



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









// ///////////////////////////////////////////////////////////////////////////////
// Select all friends with 4 letters in their name and name starts with L









// ///////////////////////////////////////////////////////////////////////////////
// Select employees who have no Techs in Tech list and name contains "Rich"
// Id 5 "Rich" will be chosen as his Tech list is empty









// ///////////////////////////////////////////////////////////////////////////////
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE
// OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE OF-TYPE

// Select only ints





// Select only strings with length greater than 5





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











// ///////////////////////////////////////////////////////////////////////////////

// String list
// Select friend with name of 5 letters











// ///////////////////////////////////////////////////////////////////////////////

// Object
// Sort employees by email where the Id is greater than 2











// ///////////////////////////////////////////////////////////////////////////////
// OrderByDescending -  OrderByDescending - OrderByDescending - OrderByDescending -
// ///////////////////////////////////////////////////////////////////////////////

// Same as OrderBy...









// ///////////////////////////////////////////////////////////////////////////////
// THENBY -  THENBY -  THENBY -  THENBY -  THENBY -  THENBY -  THENBY -  THENBY - 
// ///////////////////////////////////////////////////////////////////////////////











// ///////////////////////////////////////////////////////////////////////////////
// REVERSE -  REVERSE - REVERSE - REVERSE - REVERSE - REVERSE - REVERSE - REVERSE -
// ///////////////////////////////////////////////////////////////////////////////






//You cannot store the data like below as this method belongs to
//System.Collections.Generic namespace whose return type is void
// var method19 = intList.Reverse();











// ///////////////////////////////////////////////////////////////////////////////
// QUANTIFIERS -  QUANTIFIERS - QUANTIFIERS - QUANTIFIERS - QUANTIFIERS - QUANTIFIERS -
// ///////////////////////////////////////////////////////////////////////////////

// ///////////////////////////////////////////////////////////////////////////////
// ANY -  ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY - ANY -
// ///////////////////////////////////////////////////////////////////////////////

// Returns a BOOL!
// If ANY of the items fullfill the specified condition





// This will return TRUE



// This will return FALSE (NONE of the values are larger than 50)



// ///////////////////////////////////////////////////////////////////////////////
// CONTAINS - CONTAINS - CONTAINS - CONTAINS - CONTAINS - CONTAINS - CONTAINS -
// ///////////////////////////////////////////////////////////////////////////////

// Does Danny exist in friends list? (returns True)




// Does Richard exist in friends list? (returns False)


// ///////////////////////////////////////////////////////////////////////////////
// DISTINCT - DISTINCT - DISTINCT - DISTINCT - DISTINCT - DISTINCT - DISTINCT -
// ///////////////////////////////////////////////////////////////////////////////




// Without the ToList() method this will simply be a 'query'
// ... (and therefore nothing we can loop through)

// Return only distinct number from intList (Query only)


// Return only distinct number from intList (As a list)


// Lets have a look at the distinct names of our employees





// Lets have a look at the distinct names of our employees




// ///////////////////////////////////////////////////////////////////////////////
// TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE - TAKE -
// ///////////////////////////////////////////////////////////////////////////////

// Takes only the first 5 from the list (irrespective of value)







// Takes only the max 5 from the list (incl doublettes)




// Takes only the min 5 from the list (excl doublettes)





// ///////////////////////////////////////////////////////////////////////////////
// SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP - SKIP -
// ///////////////////////////////////////////////////////////////////////////////

// Skip the first 9 values in the list







// Skip the first 9 values in the list




// ///////////////////////////////////////////////////////////////////////////////
// FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST - FIRST -
// ///////////////////////////////////////////////////////////////////////////////

// Return the FIRST value greater that 6
// OBS: If no value matches criteria this will return an exception!!
// Lets try to change the syntax to look for number 16! What happens?






// First is the same as WHERE... but it stops at the first hit and returns a single object
// Even if there is only one number greater than 6 in the list... "Where" will return a list with one item


// ///////////////////////////////////////////////////////////////////////////////
// FIRSTORDEFAULT -  FIRSTORDEFAULT -  FIRSTORDEFAULT -  FIRSTORDEFAULT - 
// ///////////////////////////////////////////////////////////////////////////////

// Return the FIRST or DEFAULT value (if not found) greater that 6
// OBS: If no value matches criteria this will return an default value!!
// Lets try to change the syntax to look for number 16! What happens?






// ///////////////////////////////////////////////////////////////////////////////
// LOOP IN A LOOP - LOOP IN A LOOP - LOOP IN A LOOP - LOOP IN A LOOP
// ///////////////////////////////////////////////////////////////////////////////
















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

