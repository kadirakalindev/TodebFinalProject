//USERSERVİCE

using AutoMapper;
using Business.Abstract;
using Business.Configuration.Extensions;
using Business.Configuration.Response;
using Business.Configuration.Validator.FluentValidation;
using DAL.Abstract;
using DTO.User;
using FluentValidation;
using Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private IMapper _mapper;
        public UserService()
        {

        }
        public UserService(IUserRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public CommandResponse Delete(UserInfo user)
        {
            _repository.Delete(user);
            return new CommandResponse
            {
                Status = true,
                Message = "User deleted successfully"
            };
        }

        public IEnumerable<UserInfo> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public CommandResponse Insert(CreateUserRequest user)
        {
            //validation
            var validator = new CreateUserRequestValidator();
            validator.Validate(user).ThrowIfException();
            var entity = _mapper.Map<UserInfo>(user);
            //if(valid.IsValid == false)
            //{
            //    var message = string.Join(',', valid.Errors.Select(x => x.ErrorMessage));
            //    throw new ValidationException(message);
            //}
            //var entity = new UserInfo ();
            //entity.Email = user.Email;
            //entity.CarInfo = user.CarInfo;
            //entity.Phone = user.Phone;
            //entity.IdentityNumber = user.IdentityNumber;
            //entity.NameSurname = user.NameSurname;
             _repository.Insert(entity);
            return new CommandResponse
            {
                Status = true,
                Message = "User added successfully"
            };
        }

        public CommandResponse Update(UpdateUserRequest request)
        {
            
            //validation
            var validator = new UpdateUserRequestValidator();
            validator.Validate(request).ThrowIfException();
            var entity = _repository.Get(request.UserId);
            if (entity == null)
            {
                return new CommandResponse
                {
                    Status = false,
                    Message = "No record found at this id in the database"
                };
            }
            var mappedEntity = _mapper.Map(request,entity);


             _repository.Update(mappedEntity);
            return new CommandResponse
            {
                Status = true,
                Message = "User updated successfully"
            };
        }
    }
}
