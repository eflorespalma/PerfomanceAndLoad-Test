using Course.Entity;

namespace Course.Data.GiftRepository
{
    public class GiftData
    {
        readonly DatabaseService _databaseService;

        public GiftData()
        {
            _databaseService = new DatabaseService();
        }
        public int SaveGift(Gift gift)
        {
            _databaseService.Gift.Add(gift);
            _databaseService.Save();
            return gift.Id;
        }
    }
}
