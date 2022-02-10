using Xunit;

namespace TelephoneDirectory.Tests;

public class UnitTest1
{
    [Fact]
    public void TestAddContact()
    {
        //Arrange
        DirectoryAll testAddContact = new DirectoryAll();
        bool addContact = false;
        bool currentContact = true;
        //Act
        testAddContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testAddContact.AddContact(new Contact("Felipe", "1234567", "3112111111"));
        testAddContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        addContact = testAddContact.ExistContact(new Contact("Manuel"));
        //Asert
        Assert.Equal(currentContact, addContact);
    }

    [Fact]
    public void TestAddContactFail()
    {
        //Arrange
        DirectoryAll testAddContact = new DirectoryAll();
        bool addContact = false;
        bool currentContact = false;
        //Act
        testAddContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testAddContact.AddContact(new Contact("Felipe", "1234567", "3112111111"));
        testAddContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        addContact = testAddContact.ExistContact(new Contact("Luisa"));
        //Asert
        Assert.Equal(currentContact, addContact);
    }

    [Fact]
    public void TestAddContactFailTwo()
    {
        //Arrange
        DirectoryAll testAddContact = new DirectoryAll();
        bool addContact = false;
        bool currentContact = true;
        //Act
        testAddContact.AddContact(new Contact("Marcela", "1234567", "3112111"));
        testAddContact.AddContact(new Contact("Felipe", "1234567", "3112111"));
        testAddContact.AddContact(new Contact("Manuel", "1234567", "3112111"));
        addContact = testAddContact.ExistContact(new Contact("Manuel"));
        //Asert
        Assert.Equal(currentContact, addContact);
    }

    [Fact]
    public void TestAddContactFailThree()
    {
        //Arrange
        DirectoryAll testAddContact = new DirectoryAll();
        bool addContact = false;
        bool currentContact = true;
        //Act
        testAddContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testAddContact.AddContact(new Contact("Felipe", "1234567", "3112111111"));
        testAddContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        addContact = testAddContact.ExistContact(new Contact("Manuel"));
        //Asert
        Assert.Equal(currentContact, addContact);
    }

    [Fact]
    public void TestListContacts()
    {
        //Arrange
        DirectoryAll testDirectoryWhitspace = new DirectoryAll();
        int list = 0;
        int sizeList = 10;
        int currentSize = 4;
        //Act
        testDirectoryWhitspace.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Paco", "1234567", "3112111111"));
        list = testDirectoryWhitspace.DirectoryWhitspace();
        //Asert
        Assert.Equal(currentSize, sizeList - list);
    }


    [Fact]
    public void TestListContactsFail()
    {
        //Arrange
        DirectoryAll testDirectoryWhitspace = new DirectoryAll();
        int list = 0;
        int sizeList = 12;
        int currentSize = 12;
        //Act
        testDirectoryWhitspace.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Paco", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Juan", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Felipe", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Maria", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Milena", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Natalia", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Angelica", "1234567", "3112111111"));
        testDirectoryWhitspace.AddContact(new Contact("Jose", "1234567", "3112111111"));
        list = testDirectoryWhitspace.DirectoryWhitspace();
        //Asert
        Assert.Equal(currentSize, sizeList - list);
    }


    [Fact]
    public void TestExistContact()
    {
        //Arrange
        DirectoryAll testExistContact = new DirectoryAll();
        bool existContact = false;
        bool currentExistContact = true;
        //Act
        testExistContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Paco", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Fabricio", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Pepe", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Jose", "1234567", "3112111111"));
        existContact = testExistContact.ExistContact(new Contact("Fabricio"));
        //Asert
        Assert.Equal(currentExistContact, existContact);
    }

    [Fact]
    public void TestExistContactFail()
    {
        //Arrange
        DirectoryAll testExistContact = new DirectoryAll();
        bool existContact = false;
        bool currentExistContact = false;
        //Act
        testExistContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Paco", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Fabricio", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Pepe", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Jose", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Nelson", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Angela", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Mirian", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Lorena", "1234567", "3112111111"));
        testExistContact.AddContact(new Contact("Martha", "1234567", "3112111111"));
        existContact = testExistContact.ExistContact(new Contact("Nelson"));
        //Asert
        Assert.Equal(currentExistContact, existContact);
    }

    [Fact]
    public void TestSearchContact()
    {
        //Arrange
        DirectoryAll testSearchContact = new DirectoryAll();
        Contact searchContact;
        //Act
        testSearchContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        searchContact = testSearchContact.SearchContact("Marcela");
        //Asert
        Assert.NotNull(searchContact);
    }

    [Fact]
    public void TestSearchContactFail()
    {
        //Arrange
        DirectoryAll testSearchContact = new DirectoryAll();
        Contact searchContact;
        //Act
        testSearchContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        searchContact = testSearchContact.SearchContact("Roberto");
        //Asert
        Assert.Null(searchContact);
    }

    [Fact]
    public void TestSearchContactFailTwo()
    {
        //Arrange
        DirectoryAll testSearchContact = new DirectoryAll();
        Contact searchContact;
        //Act
        testSearchContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testSearchContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        searchContact = testSearchContact.SearchContact(" ");
        //Asert
        Assert.Null(searchContact);
    }

    [Fact]
    public void TestDeleteContact()
    {
        //Arrange
        DirectoryAll testDeleteContact = new DirectoryAll();
        bool deleteContact;
        bool currentdeleteteContact = true;
        //Act
        testDeleteContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Paco", "1234567", "3112111111"));
        deleteContact = testDeleteContact.DeleteContact(new Contact("Paco"));
        //Asert
        Assert.Equal(currentdeleteteContact, deleteContact);
    }

    [Fact]
    public void TestDeleteContactFail()
    {
        //Arrange
        DirectoryAll testDeleteContact = new DirectoryAll();
        bool deleteContact;
        bool currentdeleteteContact = false;
        //Act
        testDeleteContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Paco", "1234567", "3112111111"));
        deleteContact = testDeleteContact.DeleteContact(new Contact("Luisa"));
        //Asert
        Assert.Equal(currentdeleteteContact, deleteContact);
    }

    [Fact]
    public void TestDeleteContactFailTwo()
    {
        //Arrange
        DirectoryAll testDeleteContact = new DirectoryAll();
        bool deleteContact;
        bool currentdeleteteContact = false;
        //Act
        testDeleteContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Paco", "1234567", "3112111111"));
        deleteContact = testDeleteContact.DeleteContact(new Contact(" "));
        //Asert
        Assert.Equal(currentdeleteteContact, deleteContact);
    }

    [Fact]
    public void TestDeleteContactFailThree()
    {
        //Arrange
        DirectoryAll testDeleteContact = new DirectoryAll();
        bool deleteContact;
        bool currentdeleteteContact = false;
        //Act
        testDeleteContact.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Claudia", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Pedro", "1234567", "3112111111"));
        testDeleteContact.AddContact(new Contact("Paco", "1234567", "3112111111"));
        deleteContact = testDeleteContact.DeleteContact(new Contact("123456"));
        //Asert
        Assert.Equal(currentdeleteteContact, deleteContact);
    }

    [Fact]
    public void TestDirectoryFull()
    {
        //Arrange
        DirectoryAll testDirectoryFull = new DirectoryAll();
        bool directoryFull = false;
        bool currentDirectoryFull = true;
        //Act
        testDirectoryFull.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Carlos", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Juan", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Felipe", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Maria", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Milena", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Natalia", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Angelica", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Jose", "1234567", "3112111111"));
        directoryFull = testDirectoryFull.DirectoryFull();
        //Asert
        Assert.Equal(currentDirectoryFull, directoryFull);
    }

    [Fact]
    public void TestDirectoryFullFail()
    {
        //Arrange
        DirectoryAll testDirectoryFull = new DirectoryAll();
        bool directoryFull = false;
        bool currentDirectoryFull = false;
        //Act
        testDirectoryFull.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Carlos", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Juan", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Felipe", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Maria", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Milena", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Natalia", "1234567", "3112111111"));
        testDirectoryFull.AddContact(new Contact("Angelica", "1234567", "3112111111"));
        directoryFull = testDirectoryFull.DirectoryFull();
        //Asert
        Assert.Equal(currentDirectoryFull, directoryFull);
    }

    [Fact]
    public void TestDirectoryWhitSpace()
    {
        //Arrange
        DirectoryAll testDirectoryWhitSpace = new DirectoryAll();
        int spaceDirectory = 0;
        int sizeDirectory = 10;
        int currentSize = 10;
        //Act
        testDirectoryWhitSpace.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Carlos", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Paco", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Milena", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Juan", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Lucas", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Ruben", "1234567", "3112111111"));
        spaceDirectory = testDirectoryWhitSpace.DirectoryWhitspace();
        //Asert
        Assert.Equal(currentSize, sizeDirectory - spaceDirectory);
    }

    [Fact]
    public void TestDirectoryWhitSpaceFail()
    {
        //Arrange
        DirectoryAll testDirectoryWhitSpace = new DirectoryAll();
        int spaceDirectory = 0;
        int sizeDirectory = 11;
        int currentSize = 11;
        //Act
        testDirectoryWhitSpace.AddContact(new Contact("Manuel", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Carlos", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Paco", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Milena", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Marcela", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Luis", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Juan", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Miguel", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Lucas", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Ruben", "1234567", "3112111111"));
        testDirectoryWhitSpace.AddContact(new Contact("Lucas", "1234567", "3112111111"));
        spaceDirectory = testDirectoryWhitSpace.DirectoryWhitspace();
        //Asert
        Assert.Equal(currentSize, sizeDirectory - spaceDirectory);
    }
}