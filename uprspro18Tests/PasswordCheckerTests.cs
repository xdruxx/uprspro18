using Microsoft.VisualStudio.TestTools.UnitTesting;
using uprspro18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprspro18.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check8SymbolsReturnTrue()
        {
            //Arrange
            string password = "fNNr7&140";
            bool expected = true;
           
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Check8SymbolsReturnFalse()
        {
            //Arrange
            string password = "fNr7&140";
            bool expected = false;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Check4SymbolsReturnTrue()
        {
            //Arrange
            string password = "A&14";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check4SymbolsReturnFalse()
        {
            //Arrange
            string password = "A&14";
            
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        
        [TestMethod()]
        public void Check30SymbolsReturnFalse()
        {
            //Arrange
            string password = "fnr7&rigjtiijiO*tjktjah;klgfkagk566666346576634534g";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check30SymbolsReturnTrue()
        {
            //Arrange
            string password = "fnr7&rigjtiijiO*tjktjah;klgfkagk566666346576634534g";
            
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckPasswordWithDigitsReturnTrue()
        {
            //Arrange
            string password = "fnr7&63gKg";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckPasswordWithoutDigitsReturnFalse()
        {
            //Arrange
            string password = "fnr7&63gkg";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckPasswordWithSpecSymbolsReturnTrue()
        {
            //Arrange
            string password = "fNr7&63gkg";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPasswordWithoutSpecSymbolsReturnFalse()
        {
            //Arrange
            string password = "fnr7&63gkg";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPasswordWithCapsSymbolsReturnTrue()
        {
            //Arrange
            string password = "Fnr7&63gkg";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPasswordWithoutCapsSymbolsReturnFalse()
        {
            //Arrange
            string password = "fnr7&63gkg";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPasswordWithLowerSymbolsReturnTrue()
        {
            //Arrange
            string password = "Nnr7&63gkg";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPasswordWithoutLowerSymbolsReturnFalse()
        {
            //Arrange
            string password = "fnr7&63gkg";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckNullPasswordReturnsFalse()
        {
            string password = "";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckNullPasswordReturnsTrue()
        {
            string password = "A1a*";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }

    }
}