using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lecture = new LectureEvent("Talk structors", "Join us for an exciting evening of learning and inspiration at our upcoming lecture event! Hear from industry experts and thought leaders as they share their insights and experiences on a range of fascinating topics. Whether you're looking to broaden your horizons or just enjoy an informative night out, this is an event you won't want to miss!", "04/26/2023", new Address("Carlos Calvo", "CABA", "Buenos Aires", "Argentina"), "Jhon Doe", 100);
        OutdoorEvent outdoor = new OutdoorEvent("Paradise", "We've got the ultimate outdoor event experience waiting for you! Join us under the sun for a day filled with good music, tasty food, and thrilling activities. Get your friends together and make some unforgettable memories!", "05/26/2023", new Address("Pezoa 924", "San Vicente", "Buenos Aires", "Argentina"), "info@paradise.com");
        ReceptionEvent reception = new ReceptionEvent("Reception Connect", "Looking to host a memorable reception event? Look no further! Our team of experts is here to help. We offer tailored event planning services to make your reception event one-of-a-kind. From venue selection to catering and decor, we’ve got everything covered. Our team ensures that every detail is perfect, so you can sit back and enjoy your special event with loved ones. Let’s make your reception event unforgettable!", "06/26/2023", new Address("4700 N 3200th W", "Smithfield", "Utah", "United States"), "Sunny");

        Console.Clear();

        Console.WriteLine("----------------------------------------------------------------------------------");
        lecture.ShowStandardDetails(false);
        Console.WriteLine("---------");
        lecture.ShowShortDescription();
        Console.WriteLine("---------");
        lecture.ShowFullDetails();
        Console.WriteLine("----------------------------------------------------------------------------------");
        outdoor.ShowStandardDetails(false);
        Console.WriteLine("---------");
        outdoor.ShowShortDescription();
        Console.WriteLine("---------");
        outdoor.ShowFullDetails();
        Console.WriteLine("----------------------------------------------------------------------------------");
        reception.ShowStandardDetails(false);
        Console.WriteLine("---------");
        reception.ShowShortDescription();
        Console.WriteLine("---------");
        reception.ShowFullDetails();

    }
}