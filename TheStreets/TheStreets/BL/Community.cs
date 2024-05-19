namespace TheStreets.BL
{
    public class Community
    {
        int communityId;
        string name;
        string city;
        string location;
        string discription;
        string primaryPic;
        static List<Community> communitiesList = new List<Community>();

        public Community() { }
        public Community(int communityId, string name, string city, string location, string discription, string primaryPic)
        {
            this.communityId = communityId;
            this.name = name;
            this.city = city;
            this.location = location;
            this.discription = discription;
            this.primaryPic = primaryPic;
        }

        public int Insert()
        {

            return 1;
        }
        public List<Community> Read()
        {
            return communitiesList;
        }
    }
}
