using IndianStateCensusAnalyser;

namespace IndianStateCensusAnalyserTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusData.csv";
        public string stateCensusDataFilePath1 = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusData.txt";
        public string stateCensusDataFilePath2 = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusDat.csv";
        public string stateCensusDataFilePath3 = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensus.csv";
        public string StateCensusDataDelimeterFilePath = @"D:\Bridgelabz Problem statement\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusDataDelimeter.csv";


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
                StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath1);
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
                StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath2);
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
                StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath3);
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
    }
}
