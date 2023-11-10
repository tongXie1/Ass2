namespace Assignment2.Migrations
{
    using Assignment2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.Data.Assignment2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment2.Data.Assignment2Context context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Chips"},
                new Category { Name = "Cookies"},
                new Category { Name = "Crackers"},
                new Category { Name = "Popcorn"},
                new Category { Name = "Snack Mix"},
                new Category { Name = "Nuts"},
                new Category { Name = "Jerky"},
                new Category { Name = "Fruit Snacks"}
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{
                    Name = "Lay's Classic Potato Chips",
                    Price = 18.98M,
                    CategoryID= categories.Single(c => c.Name == "Chips").ID,
                    img = "/Content/Images/Lay's",
                    Description = "The perfectly crispy chip that has been America's favorite snack for more than 75 years." +
                    " Wherever celebrations and good times happen, the Lay's brand will be there. With flavors almost as rich as our history, we have a chip or crisp flavor guaranteed to bring a smile on your face." +
                    " Lays Classic potato chips are the perfect snack for any occasion. Provide the perfect portion size and classic taste to keep your customers, colleagues, and family happy." +
                    " From store shelves, to the pantry, to the lunch box, all you have to do is grab a pack and go! Lay’s is made with India’s best-quality fresh potatoes, simply sliced and cooked in edible vegetable oils and then seasoned with delicious " +
                    "flavours!. With its irresistible taste, international and Indian flavours and youth-centric imagery, Lay’s has established itself as a youth brand and continues to grow in the hearts and mind of its consumers. Lay's Classic Potato Chips" +
                    " are lightly salted, providing a balanced and savory taste that appeals to a wide range of palates. Their simple yet satisfying flavor makes them a popular snack for many occasions, whether enjoyed on their own or paired with your favorite dips. " +
                    "These chips are available in various package sizes, from small snack packs to family-sized bags, making them a versatile and timeless snack choice.",
                    Ingredients="potatoes, vegetable oil (canola, corn, soybean, and/or sunflower oil), and salt.",
                    AllergyInfo="Contains soy."},
                new Product
                {
                    Name = "Lay's Potato Chips Fried Pickles with Ranch Flavored",
                    Price = 4.48M,
                    CategoryID= categories.Single(c => c.Name == "Chips").ID,
                    img = "/Content/Images/Lay'sRanch",
                    Description = "Wherever celebrations and good times happen, the Lay's brand will be there just as it has been for more than 75 years. With flavors almost as rich as our history, we have a potato chip or crisp flavor guaranteed to bring a smile on your face." +
                    "\r\n\r\nPepsiCo is one of the world’s leading food and beverage companies serving more than 200 countries and territories around the world. For more than 50 years, as tastes, trends and lifestyles have changed, PepsiCo has evolved with them. Our willingness " +
                    "to adapt and grow has transformed our snack and soda company into a collection of global brands. Today, PepsiCo makes some of the most-popular and high-quality foods and beverages in the United States. We create smiles for our consumers — currently more" +
                    " than 1 billion a day — creating joyful moments through our delicious, nourishing products and unique brand experiences. We also bring smiles to people around the world by conserving nature's precious resources and fostering a more sustainable planet " +
                    "for our children and grandchildren.",
                    Ingredients=" Potatoes, vegetable oil (canola, corn, soybean, and/or sunflower oil), buttermilk, salt, maltodextrin (made from corn), garlic powder, spices, yogurt (cultured skim milk), natural flavors, sugar, medium chain triglycerides, onion powder, yeast" +
                    " extract, tomato powder, dextrose, paprika, gum acacia, sour cream (cultured cream, skim milk), caramel color, and papika extracts.",
                    AllergyInfo="Contains milk ingredients."
                },
                new Product{
                    Name = "OREO Chocolate Sandwich Cookies",
                    Price = 12.78M,
                    CategoryID= categories.Single(c => c.Name == "Cookies").ID,
                    img = "/Content/Images/OREO",
                    Description = "Take a delicious break with OREO Chocolate Sandwich Cookies, America's favorite since 1912. Supremely dunkable, OREO cookies sandwich a rich creme filling between two chocolate wafers--making them milk's favorite cookie. Although delicious" +
                    " enough alone or dunked in milk, OREO cookies are a great addition to your favorite desserts. Crush OREO cookies as a fun ice cream topping or milkshake mix-in. If you like baking, try adding crushed OREO cookies into cookie dough or on top of cupcakes." +
                    " Create memorable snack moments or summon smiles all around as kids dream up fun OREO cookie stack experiments and adults reminisce while enjoying this classic taste of childhood. This pack of bulk cookies contains 30 individually wrapped snack packs of OREO " +
                    "Chocolate Sandwich Cookies. Use these bulk snacks to fill your home pantry or office break room, or add it to your stock of vending machine snacks. OREO cookie snack packs are also great for selling at convenience stores, concession stands and food service stations." +
                    " Single serve packs are a convenient grab and go option for a fast, out-the-door snack, a quick lunch dessert, or a delicious treat to wind down the day. Each pack contains six OREO sandwich cookies to savor wherever the day takes you. Cocoa Life: 100% Sustainably " +
                    "Sourced Cocoa; OREO partners with Cocoa Life to help support sustainable cocoa sourcing. Cocoa life works together with farmers to grow cocoa in ways that help protect people and the planet. For more information visit the Cocoa Life website.",
                    Ingredients="unbleached enriched flour (wheat flour, niacin, reduced iron, thiamine mononitrate {vitamin b1}, riboflavin {vitamin b2}, folic acid), sugar, palm and/or canola oil, cocoa (processed with alkali), high fructose corn syrup, leavening (baking soda and/or " +
                    "calcium phosphate), salt, soy lecithin, chocolate, artificial flavor.",
                    AllergyInfo="Contains wheat and soy."},
                new Product{
                    Name = "CHIPS AHOY! Chocolate Chip Cookies",
                    Price = 9.98M,
                    CategoryID= categories.Single(c => c.Name == "Cookies").ID,
                    img = "/Content/Images/ChipsAhoy",
                    Description = "CHIPS AHOY! Original Chocolate Chip Cookies are the CHIPS AHOY! cookies you know and love, baked to have the perfect amount of crunch and crispiness. Loaded with lots of real chocolate chips, these delectable crispy chocolate chip cookies have been a " +
                    "household favorite since 1963. Enjoy the comforting taste of these classic cookies that are sure to become a household favorite. Make lunches at school or work more exciting by including CHIPS AHOY! chocolate chip cookies, or grab the bulk package of chocolate chip " +
                    "cookies to prep for a party or gathering. CHIPS AHOY! cookies sweeten any goodie bag, party favor, lunch box, gift basket, or care package. You can also add them to your favorite dessert recipes or create quick and simple appetizers.\r\n\r\nEach serving of cookies is " +
                    "only 160 calories and kosher, with no cholesterol or trans fat. The lift tab makes these three family size packages of snack cookies easy to open and close for convenient storage, and the packaging on these cookie packs keeps the cookies fresh until you're ready to enjoy " +
                    "them. Stock up on bulk food snacks to keep your family satisfied. Add this package of CHIPS AHOY! Original Chocolate Chip Cookies to your cart for simple snacks and sweet desserts.",
                    Ingredients="Unbleached enriched flour (wheat flour, niacin, reduced iron, thiamine mononitrate {vitamin b1}, riboflavin {vitamin b2}, folic acid), semisweet chocolate chips (sugar, chocolate, cocoa butter, dextrose, milk, soy lecithin), sugar, canola oil, palm oil, " +
                    "high fructose corn syrup, leavening (baking soda, ammonium phosphate), salt, natural and artificial flavor, caramel color.",
                    AllergyInfo="Contains wheat, milk, soy."},
                 new Product{
                     Name = "Kellogg's Scooby-Doo Grahams Variety Pack",
                     Price = 21.12M,
                     CategoryID= categories.Single(c => c.Name == "Crackers").ID,
                     img = "/Content/Images/Kellogg",
                     Description = "Make snack time a little sweeter with chocolate and cinnamon SCOOBY-DOO! Graham Cracker Sticks. Includes 18 one-ounce pouches of each flavor, for 36 total pouches. These fun treats are fresh and are inspired by SCOOBY-DOO’s favorite Scooby Snacks." +
                    " Featuring delightfully crispy, sweet graham crackers shaped in fun dog-bone shapes for the yummiest snacking imaginable. These delicious cookies have been baked to perfection and are made with pantry-perfect staples like whole wheat flour and a just-right hint of" +
                    " cinnamon for a satisfying treat wherever you go. No matter your age, Kellogg's Scooby-Doo! Graham Cracker Sticks are perfect for snacks at school, the office, traveling, lunchtime, at the game, and more. Satisfy your sweet treat craving with the simple goodness of" +
                    " Kellogg's SCOOBY-DOO! Graham Cracker Sticks Variety.",
                    Ingredients="Whole wheat flour, enriched flour(wheat flour, niacin, reduced iron, vitamin B1 [thiamin mononitrate], vitamin B2 [riboflavin], folic acid), sugar, vegetable oil (soybean, palm, canola and/or high oleic soybean).",
                    AllergyInfo="Contains wheat and soy ingredients."},
                 new Product{
                     Name = "RITZ Original Crackers",
                     Price = 9.98M,
                     CategoryID= categories.Single(c => c.Name == "Crackers").ID,
                     img = "/Content/Images/RITZ",
                     Description = "RITZ Original Crackers have a rich, buttery flavor that's perfect for pairing, topping or enjoying on its own. Whether it’s a formal event or a gathering of friends, these tasty round crackers are an ideal snack food, appetizer or quick meal for any occasion." +
                    " RITZ salted crackers provide a creative canvas to pair with any variety of toppings. Take your picnic to the next level by making RITZ pulled pork bites, topped with coleslaw, barbecue pork and a slice of jalapeno, or layer peanut butter, jelly or both between two crispy RITZ " +
                    "snack crackers for a special lunch treat. RITZ crackers are delicious salty snacks all on their own too, so keep them on your shelf of salty snack food for an easy anytime treat.\r\n\r\nLarge Box for Versatile Snacking Occasions\r\nThis large box of RITZ Original Crackers contains " +
                    "61.65 ounces, providing plenty to create fun and memorable snacks for school functions, birthday parties, office gatherings or summer picnics. The sturdy cardboard box protects these delicate crackers, prevents them from shifting and reduces breakage. The durable box also makes " +
                    "it easy to stack this bulk food item among other bulk snacks in your pantry or cabinet. RITZ Original Crackers are packaged in 18 individually wrapped sleeves, allowing you to eat just a few crackers at a time while the others remain fresh and delicious until you're ready to use them.",
                    Ingredients="Unbleached enriched flour (wheat flour, niacin, reduced iron, thiamine mononitrate vitamin b1, riboflavin vitamin b2, folic acid), canola oil, palm oil, sugar, salt, leavening (calcium phosphate and/or baking soda), high fructose corn syrup, soy lecithin, natural flavor.",
                    AllergyInfo="Contains wheat, soy."},
                 new Product
                 {
                     Name = "Pepperidge Farm Goldfish Crackers ",
                     Price = 12.32M,
                     CategoryID= categories.Single(c => c.Name == "Crackers").ID,
                     img = "/Content/Images/GoldFish",
                     Description = "About Pepperidge Farm Goldfish Crackers\r\nThis box contains three 22-ounce stay-fresh bags of goldfish crackers, the baked goldfish-shaped crackers made with real cheese. Each bag contains about 20 servings, for a total of about 60 servings per box. Parents love keeping " +
                     "these stocked at home as they're a snack that kids love and made with wholesome ingredients. Goldfish crackers contain no artificial flavors or preservatives and their colors are sourced from plants. Unlike other crunchy snacks, they're baked and not fried.\r\n\r\nWho Doesn't Love" +
                     " Goldfish Crackers?\r\nPack some in baggies for loading up lunchboxes for the kids and for yourself at work. Goldfish cheddar crackers are also a perfect afterschool snack as they satisfy hunger without ruining appetites before dinner. The resealable bag keeps these goldfish fresh " +
                     "and makes them easily portable."
                 },
                 new Product{
                     Name = "Buffalo Wild Wings Buttery Garlic Popcorn",
                     Price = 5.18M,
                     CategoryID= categories.Single(c => c.Name == "Popcorn").ID,
                     img = "/Content/Images/Smartfood",
                     Description = "Smartfood® first hit shelves in 1985 with a very smart idea: to create great tasting, ready-to-eat popcorn with quality ingredients. They also make a lineup of other air-popped flavors. Buffalo Wild Wings legendary sauce meets an iconic snack in this" +
                    " limited flavor combination of Buffalo Wild Wings' Parmesan Garlic with Smartfood Popcorn. The large size is perfect for sharing at your next event. Great snack for any time of day. Who comes up with these flavors? Geniuses, that’s who. After all, smart is in their" +
                    " name.\r\n\r\nPepsiCo is one of the world’s leading food and beverage companies serving more than 200 countries and territories around the world. For more than 50 years, as tastes, trends and lifestyles have changed, PepsiCo has evolved with them. Our willingness to" +
                    " adapt and grow has transformed our snack and soda company into a collection of global brands. Today, PepsiCo makes some of the most-popular and high-quality foods and beverages in the United States. We create smiles for our consumers — currently more than 1 billion a" +
                    " day — creating joyful moments through our delicious, nourishing products and unique brand experiences. We also bring smiles to people around the world by conserving nature's precious resources and fostering a more sustainable planet for our children and grandchildren.",
                    Ingredients=" Popcorn, vegetable oil (corn, canola, and/or sunflower oil), maltodextrin (made from corn), whey. and less than 2% of the following: natural flavors, salt, cream, onion powder. parmesan cheese (milk. cheese cultures, salt, enzymes). spices, dextrose, garlic powder," +
                    " cheddar cheese (milk, cheese cultures. salt, enzymes), butter (cream, salt), Swiss cheese (milk, cheese cultures. salt. enzymes) and yeast extract."},
                 new Product
                 {
                     Name = "Gold Medal Mega Pop Popcorn Kit ",
                     Price = 43.68M,
                     CategoryID= categories.Single(c => c.Name == "Popcorn").ID,
                     img = "/Content/Images/GoldPop",
                     Description = "Everything You Need\r\nThe Gold Medal Mega Pop Popcorn Kit contains everything you need the next time you decide to make some delicious mega pop popcorn. The kit contains corn, oil and salt and requires no measuring as the kit provides a suitable portion for any 12/14 oz. " +
                     "kettles. This kit produces over 12 ounces of butter-like popcorn in every bag. This means that each kit contains pre-measured portions that give you \"theater style\" popcorn servings in every batch.\r\n\r\nIs This Mega Pop Popcorn Healthy?\r\nThe Gold Medal Mega Pop Popcorn Kit " +
                     "contains no trans fats, which is beneficial for your health. A food that contains no trans fats lowers your risk of heart disease, diabetes and stroke. This is because trans fats potentially increase the levels of bad cholesterol in your body while decreasing the levels of good " +
                     "cholesterol. This Gold Medal popcorn doesn't contain any trans fats and can give you peace of mind when you eat it knowing that your heart health is in good hands.",
                 },
                 new Product{
                     Name = "Chex Mix Traditional Savory Snack Mix",
                     Price = 16.24M,
                     CategoryID= categories.Single(c => c.Name == "Snack Mix").ID,
                     img = "/Content/Images/Chex Mix",
                     Description = "Enjoy a crunchy mix of salty and savory flavors with the Chex Mix Traditional Savory Snack Mix (42 pk.). This variety pack is filled with familiar favorites like Wheat Chex, bread twists and much more.\r\n\r\nOriginal Chex Mix Variety Pack\r\nThis variety" +
                    " pack contains 42 bags of savory Chex mix, which is enough to fill up several weeks of lunch bags. Each bag contains 1.75 oz. of crunchy favorites, making it a great for a midday pick-me-up. The bags are also easy to open and easy to store in your purse, lunch box or backpack." +
                    "\r\n\r\nSavory Flavors\r\nEach variety pack contains corn Chex, rye chips, bread twists and bagel chips, as well as traditional flavors. Eat them by the handful or savor each chip one at a time. With so many shapes and sizes to enjoy, you'll have a tough time sharing these Chex " +
                    "Mix flavors with others.",
                     Ingredients="degermed" +
                    " yellow corn meal, whole wheat, enriched flour (wheat flour, niacin, reduced iron, thiamin mononitrate, riboflavin, folic acid), vegetable oil(soybean, high oleic soybean, high oleic canola, and/or palm), rye flour, sugar. contains 2% or less of: salt, yeast, maltodextrin, baking soda, " +
                    "spice, barley malt syrup, dextrose, caramel color, monoglycerides, autolyzed yeast, yellow corn flour, dried onion, trisodiu, phosphate, calcium carbonate, dried garlic, hydrolyzed soy protein, fumaric acid, caraway, disodium inosinate and guanylate, citric acid, paprika extract, natural " +
                    "flavor, sodium diacetate. freshness preserved by bht.",
                     AllergyInfo="contains wheat and soy ingredients"},
                 new Product{
                     Name = "Member's Mark Deluxe Mixed Nuts with Sea Salt",
                     Price = 11.98M,
                     CategoryID= categories.Single(c => c.Name == "Nuts").ID,
                     img = "/Content/Images/Nuts",
                     Description = "Use Member's Mark™ Deluxe Mixed Nuts with Sea Salt to curb cravings in a delicious way. This jar of mixed nuts is large enough to share.\r\n\r\nWhat’s in this Jar of Member's Mark Deluxe Mixed Nuts with Sea Salt?\r\nThis jar features a collection of delicious mixed " +
                    "nuts that you can use to relieve hunger. Roasted with sea salt, these nuts have a rich, irresistible flavor. Avoid unhealthier options like chips and candy by choosing a snack like this. In this one jar, you’ll receive cashews, almonds, pecans, pistachios and hazelnuts.\r\n\r\nWhat " +
                    "Can I Do with Member's Mark Deluxe Mixed Nuts with Sea Salt?\r\nAlthough you can eat these plain and savor their salty flavor, you can create some interesting recipes, too. Many people enjoy tossing their mixed peanuts into a salad, while others prefer to glaze them in honey, drown " +
                    "them in brown sugar, or dunk them in barbecue sauce. Add these nuts to a bowl of fruit and maybe even some chocolate for additional sweetness. Moreover, if you like to bake, add mixed nuts into the batter to give your muffins and cake some extra crunch.\r\n\r\nDo These Deluxe Mixed" +
                    " Nuts Offer Nutritional Benefits?\r\nRich with flavor, these mixed nuts are chock-full of health benefits. Natural, healthy fats and a variety of vitamins and minerals will help you reach your daily nutritional goals. Just one serving of these deluxe nuts supplies your body with " +
                    "protein, fiber, vitamin E, magnesium, and much more.",
                    Ingredients="cashews, almonds, pecans, pistachios, hazelnuts, peanut oil, sea salt.",
                    AllergyInfo="Contains almonds, pecans, cashews, hazelnuts and pistachios. May contain traces of brazil nuts, macadamia nuts, pine nuts, walnuts, peanuts."},
                 new Product{
                     Name = "Old Trapper Old Fashioned Beef Jerky ",
                     Price = 17.89M,
                     CategoryID= categories.Single(c => c.Name == "Jerky").ID,
                     img = "/Content/Images/BeefJerky",
                     Description = "The Old Trapper legend began with their Beef Jerky. They season lean cuts of real steak, add brown sugar for just the right hint of sweetness, and smoke them to perfection using real wood in our smokehouses. The smoked flavor is complemented with the perfect balance of " +
                    "sweer and savory that will indulge your senses with flavor. The result is tender, never tough jerky that will be the best you’ve ever tasted. Old Trapper Old Fashioned Beef Jerky has 11 grams of protein per serving, with 18 servings in a bag an incredible 198 grams of protein per package. " +
                    "Each serving clocks in at 70 calories so the sensible options of snacking are limitless. \r\n\r\nThe large family-size package is perfect for sharing with family and friends. You'll have enough for everyone, and they will be asking you to share. Be the most popular person in your office or" +
                    " the cul-de-sac. For over 50 years, Old Trapper Beef Jerky has been a family-owned and operated business. They craft their Old Fashioned Beef Jerky with great pride and care in the U.S., working hard every day to make great American products in America. They know you'll enjoy this top-quality," +
                    " tender, flavorful American Made beef jerky, which is why you need Old Trapper Old Fashioned Beef Jerky in the 18 oz. family size package!",
                    },
                 new Product{
                     Name = "Member's Mark Fruity Snacks",
                     Price = 9.98M,
                     CategoryID= categories.Single(c => c.Name == "Fruit Snacks").ID,
                     img = "/Content/Images/MarkFruity",
                    Description = "Member's Mark™ Fruity Snacks Variety Pack are a treat your whole family can enjoy. Each box contains 100 individually wrapped pouches of fruit-flavored snacks in a variety of flavors and colorful fruit shapes including: Cherry (red), Strawberry (light red), Raspberry (purple), " +
                    "Orange (orange) and Blueberry (blue). Individually wrapped fruit snacks are the perfect, portable treat for on the go snacking. Great for popping in lunch boxes, taking in the car or packing for your next trip. Member’s Mark Fruity Snacks can also be incorporated into your favorite at home " +
                    "dessert or snack. For an extra element of fun, add as a topping on cakes or cupcakes, sprinkle on your favorite frozen treat or even use as an element on a homemade dessert pizza. These Fruity Snacks have a mild, fruity aroma along with a soft and chewy texture. They are an excellent source " +
                    "of vitamin C and are gluten free and naturally fat free so you can feel good about the snacks you are sharing with your family.",
                    Ingredients=" Corn Syrup, Sugar, Modified Corn Starch, Gelatin and Less Than 2% of the following: Apple Puree, Citric Acid, Ascorbic Acid (Vitamin C), Natural & Artificial Flavors, Carnauba Wax, Sodium Citrate, Glycerin, Red 40, Blue 1 Yellow 5.",
                    AllergyInfo="Member’s Mark Fruity Snacks are produced in a facility that does not process products containing peanuts, tree nuts, milk, egg, wheat, or soy."},
                 new Product
                 {
                     Name = "Gushers Strawberry Splash and Tropical Flavors",
                     Price = 13.98M,
                     CategoryID= categories.Single(c => c.Name == "Fruit Snacks").ID,
                     img = "/Content/Images/Gushers",
                     Description = "What’s in a Fruit Gushers Variety Pack?\r\nGushers fruit snacks are bite-sized chewy treats that contain tasty fruit juice within the center. So once you take your first bite, you can experience a blast of juice that enhances the sweetness, making it even more delicious. In this " +
                     "one box, you’ll find two flavors: Strawberry Splash and Tropical Flavors.\r\n\r\nAre Fruit Gushers Healthy?\r\nGushers fruit snacks are gluten free and contain no artificial flavors. Additionally, they’re a good source of vitamin C, too, which is actually one of the most important vitamins" +
                     " that the human body needs. Without sufficient vitamin C, your body struggles to produce vital tissue. So, if you’re looking for a tasty way to reach your daily requirement for vitamin C, fruit gushers can be a worthwhile selection. And since each serving is only 80 calories, it’s easy to fit this into your day."
                 }
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
