using ballstore.Models;

namespace ballstore.Data
{
    public static class DbInitializer
    {
        public static void ResetAdminBalance(ApplicationDbContext context)
        {
            var admin = context.Users.FirstOrDefault(u => u.Username == "admin");
            if (admin != null)
            {
                admin.Balance = 0;
                context.SaveChanges();
            }
        }

        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            
            if (!context.Users.Any())
            {
                var users = new User[]
                {
                    new User
                    {
                        Username = "admin",
                        Password = "admin",
                        Email = "admin@ballstore.com",
                        Role = "Админ"
                    },
                    new User
                    {
                        Username = "user",
                        Password = "password",
                        Email = "user@ballstore.com",
                        Role = "Пользователь"
                    }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                var products = new Product[]
                {
                    new Product 
                    { 
                        Name = "Мяч волейбольный MIKASA V300W",
                        Price = 11999.99M,
                        Description = "Официальный игровой мяч Mikasa для игры на профессиональном уровне, подходящий для юношеских и детских соревнований",
                        ImageUrl = "/images/MIKASA V300W.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч волейбольный MIKASA V200W",
                        Price = 14999.99M,
                        Description = "Официальный игровой мяч Mikasa предназначен для проведения соревнований самого высокого уровня",
                        ImageUrl = "/images/MIKASA V200W.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч волейбольный MIKASA V345W",
                        Price = 6153.99M,
                        Description = "Облегченный мяч для тренировок начинающих волейболистов и любителей",
                        ImageUrl = "/images/MIKASA V345W.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч волейбольный TORRES BM1200 V42335",
                        Price = 4286.99M,
                        Description = "Волейбольный мяч BM1200 — это воплощение красоты и технического совершенства. Рекомендуется для соревнований и интенсивных тренировок игроков всех уровней подготовки",
                        ImageUrl = "/images/TORRES BM1200 V42335.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч для пляжного волейбола Demix",
                        Price = 899.99M,
                        Description = "Мяч Demix для пляжного волейбола и игр на открытом воздухе",
                        ImageUrl = "/images/Demix.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч волейбольный Demix Performance Soft Touch",
                        Price = 1499.99M,
                        Description = "Волейбольный мяч Demix для тренировок и любительских соревнований в зале и на открытых площадках",
                        ImageUrl = "/images/Demix Performance Soft Touch.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч волейбольный GSD Lagoon",
                        Price = 349.99M,
                        Description = "Яркий мяч GSD Lagoon размера 1 прекрасно подходит, чтобы получить первые навыки в волейболе, а также поиграть в активные игры у воды и на улице",
                        ImageUrl = "/images/GSD Lagoon.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч волейбольный GSD Attack",
                        Price = 599.99M,
                        Description = "Мяч GSD Attack — любительский мяч для классического волейбола и активного отдыха",
                        ImageUrl = "/images/GSD Attack.jpg",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Мяч волейбольный TORRES BM400 V42315",
                        Price = 2398.99M,
                        Description = "Волейбольный мяч BM400 рекомендуется для розничных продаж и комплектации бюджетных поставок в общеобразовательные учреждения, летние лагеря, базы отдыха и т.п",
                        ImageUrl = "/images/TORRES BM400.jpg",
                        InStock = true
                    },
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
} 