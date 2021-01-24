using System;
using System.Collections.Generic;
using System.Text;
using thereseWebPage.Core.DomainModel;

namespace thereseWebPage.Core.DomainService
{
    public interface IReviewsRepository
    {
        bool ConfirmOrReject(Review review);
        IEnumerable<Review> ReadAll();
    }
}
