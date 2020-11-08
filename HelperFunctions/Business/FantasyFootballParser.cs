using Newtonsoft.Json;
using System;

namespace HelperFunctions.Business
{
    public class FantasyFootballParser
    {
        public FantasyFootball Parse(string fantasyFootballJson)
        {
            var fantasyFootball = JsonConvert.DeserializeObject<FantasyFootball>(fantasyFootballJson);
            return fantasyFootball;
        }
    }
}