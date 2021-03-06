﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Contact.API.Data;

namespace Contact.API.Repository
{
    public interface IContactFriendRequestRepository
    {
        Task<IEnumerable<FriendRequest>> GetFriendRequestListAsync(int userId);
        Task AddFriendAsync(FriendRequest request);
        Task PassFriendRequestAsync(int userId, int appliedUserId);
        Task RejectFriendRequestAsync(int userId, int appliedUserId);
        Task<bool> ExistFriendRequestAsync(int userId, int appliedUserId);
    }
}