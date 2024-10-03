
        class Costume;
            public string gloves;

            public string upperGarment;

            public string lowerGarment;

            public string headware;

            public string accessory;

            public string shoes;

            public void showWardrobe();
            {
                string result = "";
                result += "Head gear: " + headware;
                result += "Hand gear: " + gloves;
                result += "Foot gear: " + shoes;
                result += "Torse covering: " + upperGarment;
                result += "Leg covering: " + lowerGarment;
                result += "Accessory: " + accessory;
                Console.WriteLine(result)
            }
