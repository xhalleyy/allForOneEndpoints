namespace allForOneEndpoints.Services.MadLib;

public interface IMadLibService
{
    string Story(string creature, string name1, string name2, string place, string item, string noun, string adjective, string adverb, string ingVerb1, string ingVerb2, string pastVerb1);
}
