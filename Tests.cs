using AddressBook_ADO.NET;

namespace AddressBookADO.NET_TEST
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Updates the contact details. UC17
        /// </summary>
        /// <returns></returns>
        public AddressBookContactDetails UpdateContactDetails()
        {
            //passing data for updating
            AddressBookContactDetails contactDetails = new AddressBookContactDetails();
            contactDetails.firstName = "Chandru";
            contactDetails.lastName = "Kalahalamath";
            contactDetails.address = "Gadag";
            contactDetails.city = "Gadag";
            contactDetails.state = "Karnataka";
            contactDetails.zip = 582103;
            contactDetails.phoneNo = 7406140157;
            contactDetails.eMail = "chandru@gmail.com";
            contactDetails.addressBookName = "A";
            //passing data to update method in address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            bool result = addressBookOperations.UpdateContactDetailsInDataBase(contactDetails);
            Console.WriteLine(result);
            return contactDetails;
        }
        [TestMethod]
        public void CheckingIfContactDetailsAreGettingUpdated()
        {
            //calling update contact details
            //getting actual data
            AddressBookContactDetails actual = UpdateContactDetails();
            AddressBookContactDetails contactDetails = new AddressBookContactDetails();
            //passing data to get updated contact details
            contactDetails.firstName = "Chandru";
            contactDetails.lastName = "K";
            contactDetails.addressBookName = "A";
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting expected data from address book operations -getting updated details
            AddressBookContactDetails expected = addressBookOperations.GettingUpdatedDetails(contactDetails);
            //assert
            Assert.AreEqual(expected, actual);


        }

        /// <summary>
        /// checking that we are getting the contacts based on the time range.
        /// </summary>
        [TestMethod]
        public void CheckingForGettingContactDetailsInParticularTimeRange()
        {
            //creating list for expected output
            List<AddressBookContactDetails> contactDetailsExpected = new List<AddressBookContactDetails>();
            //adding data
            contactDetailsExpected.Add(new AddressBookContactDetails { firstName = "Chandru", lastName = "K", address = "Gadag", city = "Gadag", state = "Karnataka", zip = 582103, phoneNo = 7406140157, eMail = "chandru@gmail.com" });
            //instatiating object for address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting actual contact list from address book operations-getting contact details from particular date range
            List<AddressBookContactDetails> contactDetailsActual = addressBookOperations.GetAllContactDetailsForParticularDateRange();
            //assert for comparing list
            CollectionAssert.AreEqual(contactDetailsActual, contactDetailsExpected);
        }


        /// <summary>
        /// Checkings for getting contact details for particular state. UC19
        /// </summary>
        [TestMethod]
        public void CheckingForGettingContactDetailsForParticularState()
        {
            //creating list for expected output
            List<AddressBookContactDetails> contactDetailsExpected = new List<AddressBookContactDetails>();
            //adding data
            contactDetailsExpected.Add(new AddressBookContactDetails { firstName = "Sai", lastName = "P", address = "KSRTC Colony", city = "Hubli", state = "Karnataka", zip = 582141, phoneNo = 9909587463, eMail = "saip@gmail.com" });
            //instatiating object for address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting actual contact list from address book operations-getting contact details from particular date range
            List<AddressBookContactDetails> contactDetailsActual = addressBookOperations.GetAllContactDetailsWithConditions();
            //assert for comparing list
            CollectionAssert.AreEqual(contactDetailsActual, contactDetailsExpected);
        }
        /// <summary>
        /// Checkings for getting contact details for particular city. UC19
        /// </summary>
        [TestMethod]
        public void CheckingForGettingContactDetailsForParticularCity()
        {
            //creating list for expected output
            List<AddressBookContactDetails> contactDetailsExpected = new List<AddressBookContactDetails>();
            //adding data
            contactDetailsExpected.Add(new AddressBookContactDetails { firstName = "Chandru", lastName = "K", address = "Gadag", city = "Gadag", state = "Karnataka", zip = 582103, phoneNo = 7406140157, eMail = "chandru@gmail.com" });

            //instatiating object for address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting actual contact list from address book operations-getting contact details from particular date range
            List<AddressBookContactDetails> contactDetailsActual = addressBookOperations.GetAllContactDetailsWithConditions();
            //assert for comparing list
            CollectionAssert.AreEqual(contactDetailsActual, contactDetailsExpected);
        }
    }
}
