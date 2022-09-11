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
            contactDetails.lastName = "K";
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
            contactDetails.lastName = "Kalahalamath";
            contactDetails.addressBookName = "A";
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting expected data from address book operations -getting updated details
            AddressBookContactDetails expected = addressBookOperations.GettingUpdatedDetails(contactDetails);
            //assert
            Assert.AreEqual(expected, actual);


        }
    }
}


