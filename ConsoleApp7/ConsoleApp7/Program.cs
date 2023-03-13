using Microsoft.Win32;

namespace ConsoleApp7
{

    class citizen
    {
        public string hairColour;
        public int height;
        public int width;
        public string gender;
        public string eyeColour;
        public bool married;
        public string address;
        public int ID;
        public int budget_in_the_bank;
        public int number_of_crimes;
        //This is 10 attributes

        public citizen()
        {
            hairColour = "Black";
            height = 50;
            width = 20;
            gender= "Male";
            eyeColour = "Black";
            married = false;
            address = "US";
            ID= 123;
            budget_in_the_bank= 0;
            number_of_crimes = 0;

        }

        public citizen(string haircolor)
        {
            hairColour= haircolor;
        }

        public citizen( string haircolor, int height)
        {
            hairColour= haircolor;
            this.height= height;
        }

        public citizen(string haircolor,int height ,int width , string gender)
        {
            hairColour= haircolor;
            this.height= height;
            this.width= width;
            this.gender= gender;
        }

        public citizen(string haircolor, int height, int width, string gender,string eyecolor ,bool married)
        {
            hairColour= haircolor;
            this.height= height;
            this.width= width;
            this.gender= gender;
            this.eyeColour= eyecolor;
            this.married= married;

        }

        // This is 5 constructors

        public void PrintCitizenInfo()
        {
            Console.WriteLine("hairColour : {0}\nheight : {1}\nwidth : {2}\ngender : {3}\neyeColour : {4}\nmarried : {5}\naddress : {6}\nID : {7}", hairColour,height,width,gender,eyeColour,married,address,ID);
        }

        public void if_can_obtain_Egyptian_citizenship()
        {
            if (married)
            {
                Console.WriteLine("This person can get the egyptian citizenship");
            }
            else
                Console.WriteLine("This person can not get the egyptian citizenship");

        }

        public void TallOrShort()
        {
            if (height >= 200)
            {
                Console.WriteLine("This person is tall");
            }
            else
                Console.WriteLine("This person is short");

        }

        public void Fat()
        {
            if (width > 50)
            {
                Console.WriteLine("This person is fat");
            }
            else
                Console.WriteLine("This person is not fat");

        }

        public void Rich()
        {
            if (budget_in_the_bank >= 10000)
            {
                Console.WriteLine("This person is rich");
            }
            else
                Console.WriteLine("This person is poor");

        }

        public void isJailed()
        {
            if (number_of_crimes > 0)
            {
                Console.WriteLine("This person is Jailed");
            }
            else
            {
                Console.WriteLine("This person is not Jailed");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            citizen Adel = new citizen();
            Adel.married= true;
            Adel.height= 200;
            Adel.width= 60;
            Adel.budget_in_the_bank = 10000;
            Adel.number_of_crimes= 5;
            
            Adel.PrintCitizenInfo();
            Adel.if_can_obtain_Egyptian_citizenship();
            Adel.TallOrShort();
            Adel.Fat();
            Adel.Rich();
            Adel.isJailed();


        }
    }
}