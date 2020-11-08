using HelperFunctions.Business;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace HelperFunctionsTest
{
    public class FantasyFootballParserTests
    {
        [Fact]
        public void Test1()
        {
            var fantasyFootballString = ExtractResource("BootstrapStatic.json");

            var fantasyFootballParser = BuildFantasyFootballParser();
            var fantasyFootball = fantasyFootballParser.Parse(fantasyFootballString);

            Assert.NotNull(fantasyFootball);
        }

        private string ExtractResource(string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fullFilename = $"HelperFunctionsTest.{filename}";

            using var stream = assembly.GetManifestResourceStream(fullFilename);
            using var reader = new StreamReader(stream);
            string jsonFile = reader.ReadToEnd(); //Make string equal to full file
            return jsonFile;
        }

        private static FantasyFootballParser BuildFantasyFootballParser()
        {
            var fantasyFootballParser = new FantasyFootballParser();
            return fantasyFootballParser;
        }
    }
}
