namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedFriendArray = new string[3][];
            jaggedFriendArray[0] = new string[3];
            jaggedFriendArray[1] = new string[3];
            jaggedFriendArray[2] = new string[3];
            jaggedFriendArray[0][0] = "David";
            string[] familyMembers1 = new string[2];
            familyMembers1 = AddFamilyMember(jaggedFriendArray[0][0]);
            for (int i = 0; i < familyMembers1.Length; i++)
            {
                jaggedFriendArray[0][i+1] = familyMembers1[i];
            }
            jaggedFriendArray[1][0] = "Lina";
            string[] familyMembers2 = new string[2];
            familyMembers2 = AddFamilyMember(jaggedFriendArray[1][0]);
            for (int i = 0; i < familyMembers2.Length; i++)
            {
                jaggedFriendArray[1][i+1] = familyMembers2[i];
            }
            jaggedFriendArray[2][0] = "Diego";
            string[] familyMembers3 = new string[2];
            familyMembers3 = AddFamilyMember(jaggedFriendArray[2][0]);
            for (int i = 0; i < familyMembers3.Length; i++)
            {
                jaggedFriendArray[2][i+1] = familyMembers3[i];
            }

            Console.WriteLine("\nThe friend jagged Array is: ");
            foreach (string[] row in jaggedFriendArray)
            {
                foreach(string familyMember in row)
                {
                    Console.WriteLine(familyMember);
                }
                Console.WriteLine("\n");
            }
        }

        public static string[] AddFamilyMember(string friend)
        {
            string[] members = new string[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{friend} please enter your first family member: ");
                string input = Console.ReadLine();
                members[i] = input;
            }
            return members;
        }
    }
}