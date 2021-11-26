using System.Collections.Generic;

namespace MauiDemo
{
    public class Animal
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }

    public class Animals : List<Animal> {
        public Animals() {
            this.Add(new Animal{Name="Lion",       Image="lion", Description        ="The world's most social felines, lions roam the savannas and grasslands of the African continent, hunting cooperatively and raising cubs in prides."});
            this.Add(new Animal{Name="Zebra",      Image="zebra", Description       ="Each zebra has its own unique pattern of distinctive stripes, just as humans have their own unique pattern of fingerprints. Zebras stick together in herds."});
            this.Add(new Animal{Name="Rhinoceros", Image="rhino", Description       ="Rhinoceros any of five or six species of giant horn-bearing herbivores that include some of the largest living land mammals. Only African and Asian elephants are taller at the shoulder than the two largest rhinoceros species."});
            this.Add(new Animal{Name="Elephant",   Image="elephant", Description    ="Elephants are the largest land mammals on earth and have distinctly massive bodies, large ears, and long trunks. They use their trunks to pick up objects, trumpet warnings, greet other elephants, or suck up water for drinking or bathing, among other uses."});
            this.Add(new Animal{Name="Cheetah",    Image="cheetah", Description     ="The cheetah is the fastest land animal in the world, reaching speeds of up to 70 miles per hour. They can accelerate from 0 to 68 miles per hour in just three seconds."});
            this.Add(new Animal{Name="Giraffe",    Image="giraffe", Description     ="At an average height of around 5 m (16-18 ft.), the giraffe is the tallest land animal in the world. Giraffes live primarily in savanna areas in the sub-Saharan region of Africa."});
            this.Add(new Animal{Name="African buffalo", Image="buffalo", Description="The African Buffalo is a bovine species that is widely spread across Africa. It belongs to the famous \"Big Five\". Usually, African buffaloes form large herds."});
            this.Add(new Animal{Name="Hippopotamus", Image="hippo", Description     ="Hippos are the third-largest living land mammal, after elephants and white rhinos. They have very thick skin that is virtually hairless except for the thick bristle-like hair on their heads and tails."});
            this.Add(new Animal{Name="Wild dog", Image="wilddog", Description       ="Wild dogs are social and gather in packs of around ten individuals, but some packs number more than 40. They are opportunistic predators that hunt medium-sized ruminants, such as gazelles."});
            this.Add(new Animal{Name="Meerkat", Image="meerkat", Description        ="These gregarious animals are often seen in groups, and several families may live together in a large community. Squirrel-sized meerkats are mongooses famed for their upright posture."});
            this.Add(new Animal{Name="Ostrich", Image="ostrich", Description        ="Massive, conspicuous, flightless bird with long neck and robust legs. Mature males have black-and-white plumage, with pinkish skin, flushed in breeding plumage. Females and immatures are duller gray-brown. They can walk up to several kilometers a day."});
            this.Add(new Animal{Name="Gorilla", Image="gorilla", Description        ="Gorillas are some of the most powerful and striking animals, not only for their size and force, but also for their gentle human like behavior. They play a crucial role in local biodiversity, roaming through large territories and helping, for example, to spread the seeds of the fruit they consume."});        }
    }
}