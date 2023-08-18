using IndianStateCensusAnalyser;

namespace IndianStateCensusAnalyserTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusData.csv";
        public string stateCensusDataTxtFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusData.txt";
        public string stateCensusDataNotExistFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusDat.csv";
        public string stateCensusDataHeaderFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensus.csv";
        public string StateCensusDataDelimeterFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusDataDelimeter.csv";

        public string stateCodeDataFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCode.csv";
        public string stateCodeDataTxtFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCode.txt";
        public string stateCodeDataNotExistFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCod.csv";
        public string stateCodeDataHeaderFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCodeHeader.csv";
        public string stateCodeDataDelimeterFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCodeDelimeter.csv";



        [Test]
        public void GivenStateCencusData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath),CSVStateCensus.ReadStateCensusData(stateCensusDataFilePath));   
            Assert.Pass();
        }
        [Test]
        public void GivenStateCencusDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(stateCensusDataTxtFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }
            
        }
        [Test]
        public void GivenStateCencusDataFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(stateCensusDataNotExistFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }

        }
        [Test]
        public void GivenStateCensusHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(stateCensusDataHeaderFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
        [Test]
        public void GivenStateCensusDelimeterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(StateCensusDataDelimeterFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }
        //---------------------------------------------
        [Test]
        public void GivenStateCodeData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCodeAnalyser.ReadStateCodeData(stateCodeDataFilePath), CSVStateCode.ReadStateCodeData(stateCodeDataFilePath));
            Assert.Pass();
        }
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataTxtFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }

        }
         [Test]
        public void GivenStateCodeDataFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataNotExistFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }

        }
        [Test]
        public void GivenStateCodeHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataHeaderFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
        [Test]
        public void GivenStateCodeDelimeterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataDelimeterFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }
    }
}
