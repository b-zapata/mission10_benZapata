﻿namespace mission10benZapata.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext  = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
    }
}
