using Grpc.Core;
using GrpcServer.Protos;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class UserService : User.UserBase
    {
        public override async Task<UserReply> Login(UserRequest request, ServerCallContext context)
        {
            UserReply userReply = new UserReply();
            userReply.UserName = request.UserName;
            userReply.Password = request.Password;
            userReply.Token = request.UserName + "|" + request.Password;

            return await Task.FromResult(userReply);
        }
    }
}
