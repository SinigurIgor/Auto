using BusinessLogic.Interfaces;


namespace BusinessLogic
{
    public class BusinessLogic1
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
