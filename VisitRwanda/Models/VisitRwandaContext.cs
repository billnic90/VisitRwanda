using Microsoft.EntityFrameworkCore;

namespace VisitRwanda.Models
{
    public class VisitRwandaContext : DbContext
    {
        public VisitRwandaContext(DbContextOptions<VisitRwandaContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<Investment> Investments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Destination data seeding
            modelBuilder.Entity<Destination>().HasData(
                new Destination
                {
                    DestinationID = 1,
                    Name = "Nyungwe National Park",
                    Description = "One of the oldest rainforests in Africa, Nyungwe is rich in biodiversity and spectacularly beautiful. The mountainous region is teaming with wildlife, including a small population of chimpanzees as well as 12 other species of primate.",
                    Location = "Southern Province",
                    Image = "Nyungwe.jpg"
                },
                new Destination
                {
                    DestinationID = 2,
                    Name = "Nyanza",
                    Description = "Home to the King's Palace a reconstruction of the traditional royal residence, a beautifully crafted thatched dwelling shaped like a beehive.",
                    Location = "Southern Province",
                    Image = "Nyanza.jpg"
                },
                new Destination
                {
                    DestinationID = 3,
                    Name = "Lake Kivu",
                    Description = "Part of Africa’s Great Rift Valley, Lake Kivu is dotted with islands and inlets along its shoreline, with charming beach resorts, spectacular vistas and plenty of opportunities for hiking and cycling.",
                    Location = "Western Province",
                    Image = "LakeKivu.jpg"
                },
                new Destination
                {
                    DestinationID = 4,
                    Name = "Akagera National Park",
                    Description = "The relatively warm and low‑lying plains of Akagera comprise savannah, woodland, wetland and a dozen lakes. In partnership with African Parks, we have reintroduced lions and rhinos, meaning once again visitors can hope to see the Big Five on safari drives.",
                    Location = "Eastern Province",
                    Image = "AkageraView.jpg"
                },
                new Destination
                {
                    DestinationID = 5,
                    Name = "Volcanoes National Park",
                    Description = "“In the heart of Central Africa, so high up that you shiver more than you sweat,” wrote Dian Fossey. “Great, old volcanoes towering almost 15,000 feet, nearly covered with rich, green rainforest—the Virungas.”",
                    Location = "Northern Province",
                    Image = "Volcanoes.jpg"
                },
                new Destination
                {
                    DestinationID = 6,
                    Name = "Kigali",
                    Description = "The capital city is pleasantly low key yet dynamic and progressive. It's green, clean and safe with meaningful culture and remarkable drive.",
                    Location = "Kigali",
                    Image = "Kigali.jpg"
                }
                );
            // Culture data seeding
            modelBuilder.Entity<Culture>().HasData(
        new Culture
        {
            CultureID = 1,
            Title = "Rwandan Culture and Traditions",
            Description = "Rwandan culture has many traditions including traditional Intore dancing, basketry and Umuganda.",
            Image = "CultureTraditions.png"
        },
        new Culture
        {
            CultureID = 2,
            Title = "Rwanda Art Museum",
            Description = "Formerly the Presidential Palace Museum, this new museum displays contemporary artworks from Rwanda as well as abroad.It hosts temporary and travelling exhibitions alongside the permanent collection.",
            Image = "RwandaArtMuseum.jpg"
        },
        new Culture
        {
            CultureID = 3,
            Title = "Kigali Genocide Memorial",
            Description = "The Kigali Genocide Memorial at Gisozi is where 250,000 victims have been buried. This memorial also serves to educate about how the 1994 Genocide against the Tutsi took shape and examines genocide in the 20th century. ",
            Image = "KigaliGenocide.jpg"
        },
        new Culture
        {
            CultureID = 4,
            Title = "Kandt House Museum",
            Description = "The Kandt House Museum looks at colonialism in relation to Rwanda, set in the old house of the first colonial governor.",
            Image = "KandtHouse.jpg"
        },
        new Culture
        {
            CultureID = 5,
            Title = "Fashion & Style",
            Description = "Though it would have been a pipe dream some years ago, today Kigali is cosmopolitan enough to host not one, but two fashion festivals every year, and for fashionistas and those on the cutting edge of style, they offer a fantastic opportunity to see the cultural fusion of western and Rwandan styles that the country’s finest designers negotiate and create daily. Kigali Fashion Week takes place every July, and hosts dozens of international, local, and upcoming young designers, while the Rwanda Cultural Fashion Week showcases even more local and international talent every September.",
            Image = "FashionStyle.jpg"
        }
            );
            // Investment data seeding
            modelBuilder.Entity<Investment>().HasData(
    new Investment
    {
        InvestmentID = 1,
        Sector = "Agriculture",
        Description = "Modern tea plantation projects expanding Rwanda’s exports and promoting sustainable farming.",
        Requirements = "Minimum investment of $100,000 and partnership with local cooperatives.",
        Image = "Agriculture.jpg"
    },
    new Investment
    {
        InvestmentID = 2,
        Sector = "Technology",
        Description = "An ICT hub in Kigali offering tax incentives and world class digital infrastructure.",
        Requirements = "Registration with Rwanda Development Board and local office setup.",
        Image = "Technology.jpg"
    },
    new Investment
    {
        InvestmentID = 3,
        Sector = "Tourism",
        Description = "Eco lodge developments near national parks to boost eco tourism and conservation.",
        Requirements = "Environmental impact assessment approval.",
        Image = "Tourism.jpg"
    },
    new Investment
    {
        InvestmentID = 4,
        Sector = "Manufacturing",
        Description = "Light manufacturing parks in the Kigali Special Economic Zone with streamlined customs.",
        Requirements = "Land lease agreement and compliance with factory standards.",
        Image = "Manufacturing.png"
    },
    new Investment
    {
        InvestmentID = 5,
        Sector = "Energy",
        Description = "Rwanda is pioneering renewable technologies, with a methane gas plant on Lake Kivu supplying 14% of our energy requirements, and a growing solar sector.",
        Requirements = "Partnerships with local energy providers and RDB registration.",
        Image = "Energy.jpg"
    }
);
        }
    }
}