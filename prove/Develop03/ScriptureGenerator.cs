
using System;

public class ScriptureGenerator
{


    public static Scripture GetRandomScripture()
    {
        Scripture scripture = new Scripture(new Reference("Proverbs", "3", "5", "6"), "Trust in the Lord with all thine hearth and lean not unto thine own un derstanding; in all thy ways acknowledge him, and he shall direct thy paths");
        Scripture scripture1 = new Scripture(new Reference("Moses", "6", "52"), "And he also said unto him: If thou wilt turn unto me, and hearken unto my voice, and believe, and repent of all thy transgressions, and be baptized, even in water, in the name of mine Only Begotten Son, who is full of grace and truth, which is Jesus Christ, the only name which shall be given under heaven, whereby salvation shall come unto the children of men, ye shall receive the gift of the Holy Ghost, asking all things in his name, and whatsoever ye shall ask, it shall be given you.");
        Scripture scripture2 = new Scripture(new Reference("Moses", "1", "11"), "But now mine own eyes have beheld God; but not my natural, but my spiritual eyes, for my natural eyes could not have beheld; for I should have withered and died in his presence; but his glory was upon me; and I beheld his face, for I was transfigured before him.");
        Scripture scripture3 = new Scripture(new Reference("1 Nephi", "11", "21"), "And the angel said unto me: Behold the Lamb of God, yea, even the Son of the Eternal cFather! Knowest thou the meaning of the tree which thy father saw?");
        Scripture scripture4 = new Scripture(new Reference("Doctrine and Convenants", "19", "18"), " Which suffering caused myself, even God, the greatest of all, to tremble because of pain, and to bleed at every pore, and to suffer both body and spirit—and would that I might not drink the bitter cup, and shrink—");

        Scripture[] scriptures = new[] { scripture, scripture1, scripture2, scripture3, scripture4 };
        Random random = new Random();
        int index = random.Next(0, scriptures.Length);
        return scriptures[index];
    }
}