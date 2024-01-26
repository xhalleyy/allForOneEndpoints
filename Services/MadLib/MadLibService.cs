namespace allForOneEndpoints.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string Story(string creature, string name1, string name2, string place, string item, string noun, string adjective, string adverb, string ingVerb1, string ingVerb2, string pastVerb1)
    {
        return $"There once was {name1} the {creature}. They lived a(n) {adjective} life in a small and humble village. One day, someone came to their village wreaking havoc! {name2}, the wicked King of the Fireants, came {ingVerb1} with his army. {name2} sought to rule over the continent by invading every spec of land. Many villages met their undoing with their persistent terrorization and colonization! Unfortunately, {name1} had lost everything, so {name1} sought for revenge! On their journey to defeat the King of the Fireants, {name1} formed a crew. As the crew trekked on, they stumbled across a(n) {item}, a magical item that can aid in defeating {name2}. Meanwhile, {name2} settled down at the {place}. Thus when {name1} eventually caught up to the King, the King was caught off guard as he was {ingVerb2}. The {name2}, the King, was enraged, which led to a gruesome fight! Because of the size of the fireants, it was looking grim for {name1}'s crew. However, {name1} remembered about the {item}! {name1} {pastVerb1} their way to the King and -- Bonk! The {item} was struck on {name2}'s head. This magical item immobilized the King and his army, so they victors were able to lock them up in a(n) {noun} for all eternity. {name1} the {creature} and his crew lived their life {adverb} ever after. The end!";
    }
}
